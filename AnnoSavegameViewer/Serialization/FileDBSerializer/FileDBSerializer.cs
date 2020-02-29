using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Serialization.Memory;
using AnnoSavegameViewer.Serialization.Reflection.TypeData;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace AnnoSavegameViewer.Serialization.FileDBSerializer {

  public static class FileDBSerializer {

    #region Public Methods

    public async static Task<T> ConvertAsync<T>(ReadOnlyMemory<byte> memory) {
      var typeData = TypeData.GetTypeData(typeof(T));
      var instance = typeData.GetInstance();
      var objectStack = new Stack();
      objectStack.Push(instance);
      var currentObject = instance;
      var unclosedNodes = 0;
      MemberData member = null;
      await foreach (var item in FileDBSerializer.EnumerateTreeAsync(memory)) {
        switch (item.serializingType) {
          // Node
          case SerializingType.OpenNode:
            //Handle non serialized trees
            if (unclosedNodes != 0) {
              unclosedNodes++;
            }
            //Check data required by member
            else {
              currentObject = objectStack.Peek();
              typeData = TypeData.GetTypeData(currentObject.GetType());

              //Find matching member
              typeData.UnorderedNodes.TryGetValue(item.Name, out member);
              //Not required
              if (member == null) {
                unclosedNodes++;
              }
              //Serialize data
              else {
                var memberTypeData = TypeData.GetTypeData(member.Type);
                object memberObject = null;
                object value = null;

                var elementType = member.Type.GetFirstUnderlayingType();

                if (elementType == null) {
                  memberObject = memberTypeData.GetInstance();
                  member.MemberInfo.SetMemberValue(currentObject, memberObject);
                }
                else if (member.Type.IsGenericType) {
                  var existingObject = member.MemberInfo.GetMemberValue(currentObject);
                  if (existingObject == null) {
                    existingObject = memberTypeData.GetInstance();
                    member.MemberInfo.SetMemberValue(currentObject, existingObject);
                  }

                  if (existingObject is IList list) {
                    memberObject = TypeData.GetTypeData(elementType).GetInstance();
                    list.Add(memberObject);
                  }
                  else {
                    throw new NotImplementedException(
                          $"Type {member.Type} is not supported by the serializer.");
                  }
                }
                else {
                  throw new NotImplementedException(
                       $"Type {member.Type} is not supported by the serializer.");
                }

                objectStack.Push(memberObject);
              }
            }

            break;

          // Close Node
          case SerializingType.CloseNode:
            if (unclosedNodes > 0)
              unclosedNodes--;
            else
              objectStack.Pop();
            break;

          // Attribute
          case SerializingType.Content:
            currentObject = objectStack.Peek();
            typeData = TypeData.GetTypeData(currentObject.GetType());

            //Find matching member
            typeData.UnorderedAttributes.TryGetValue(item.Name, out member);
            if (member != null) {
              ReadMember(currentObject, member, in item.Content);
              break;
            }
            break;

          default:
            break;
        }
      }
      return (T)instance;
    }

    public async static IAsyncEnumerable<(string Name, SerializingType serializingType, ReadOnlyMemory<byte> Content)>
      EnumerateTreeAsync(ReadOnlyMemory<byte> memory) {
      var reader = new MemoryReader(memory);

      //Check Compression
      if (reader.ReadInt16() == -9608) {
        reader = new MemoryReader(await memory.ZlibDecompressAsync());
      }

      //Set Position from The Tags Section
      var TagsOff = reader.Position = System.Convert.ToInt32(MemoryMarshal.Read<UInt32>(reader.Memory.Span[^4..]));

      //Read Tags
      var tags = FileDBSerializer.GetTagDictionary(ref reader);

      //Array Elements
      tags.Add(1, "None");
      tags.Add(32768, "None");
      await foreach (var item in EnumerateNodesAsync(reader.Memory, tags, TagsOff)) {
        yield return item;
      }
    }

    #endregion Public Methods

    #region Private Methods

    private static void ReadMember(object instance, MemberData member, in ReadOnlyMemory<byte> content) {
      object value = null;
      var elementType = member.Type.GetFirstUnderlayingType();
      //Handle Arrays
      if (member.Type.IsArray) {
        Array values = Array.CreateInstance(elementType, member.Attribute.Length);
        for (int i = 0; i < values.Length; i++) {
          var reader = content.ToReader();
          values.SetValue(reader.ReadObject(elementType, member.Attribute), i);
        }
        value = values;
      }
      // Handle Generics
      else if (member.Type.IsGenericType) {
        //Get or set existing object
        var existingObject = member.MemberInfo.GetMemberValue(instance);
        if (existingObject == null) {
          existingObject = TypeData.GetTypeData(member.Type).GetInstance();
          member.MemberInfo.SetMemberValue(instance, existingObject);
        }

        if (existingObject is IList list) {
          list.Add(content.ReadObject(elementType, member.Attribute));
        }
        else {
          throw new NotImplementedException(
          $"Type {member.Type} is not supported by the serializer.");
        }
        return;
        //value = existingObject;
      }
      else {
        value = content.ReadObject(member.Type, member.Attribute);
      }

      member.MemberInfo.SetMemberValue(instance, value);
    }

    private static Dictionary<ushort, string> GetTagDictionary(ref MemoryReader reader) {
      var dictionary = new Dictionary<ushort, string>();
      //Nodes
      var count = reader.ReadInt32Bit7();
      for (var i = 0; i < count; i++) {
        var name = reader.ReadString(null, StringPattern.ZeroTerminated);
        var id = reader.ReadUInt16();

        dictionary.Add(id, name);
      }
      //Attributes
      count = reader.ReadInt32Bit7();
      for (var i = 0; i < count; i++) {
        var name = reader.ReadString(null, StringPattern.ZeroTerminated);
        var id = reader.ReadUInt16();

        dictionary.Add(id, name);
      }
      return dictionary;
    }

    private async static IAsyncEnumerable<(string Name, SerializingType serializingType, ReadOnlyMemory<byte> Content)>
      EnumerateNodesAsync(ReadOnlyMemory<byte> memory, Dictionary<ushort, string> tags, int tagsOffset) {
      //Get Nodes Section
      var reader = new MemoryReader(memory[..tagsOffset]);
      ushort nextId;
      int length;

      while (reader.Position < reader.Length) {
        //Get Next ID
        nextId = reader.ReadUInt16();

        //Close Node
        if (nextId == 0) {
          yield return (default, SerializingType.CloseNode, default);
        }

        //Check for Existing Id
        else if (tags.TryGetValue(nextId, out var tag)) {
          //Node
          if (nextId < 32768) {
            yield return (tag, SerializingType.OpenNode, default);
          }

          //Attribute
          else {
            length = reader.ReadInt32Bit7();

            //Extract Sub Nodes
            if (tag == "BinaryData") {
              yield return (tag, SerializingType.OpenNode, default);
              await foreach (var item in EnumerateTreeAsync(reader.Memory.Slice(reader.Position, length))) {
                yield return item;
              }
            }

            //Read Normal Attribute
            else {
              yield return (tag, SerializingType.Content, reader.Memory.Slice(reader.Position, length));
            }
            reader.Position += length;
          }
        }
      }
    }

    #endregion Private Methods
  }
}