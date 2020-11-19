// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Serialization {
  using AnnoSerializer.Serialization.Core;
  using AnnoSerializer.Serialization.Memory;
  using AnnoSerializer.Serialization.Reflection.TypeData;
  using AnnoSerializer.Structures.FileDB;
  using System;
  using System.Collections;

  public static class FileDBSerializer {

    #region Public Methods

    public static T Convert<T>(ReadOnlyMemory<byte> memory) => (T)(Convert(memory, typeof(T), out var _));

    public static object Convert(ReadOnlyMemory<byte> memory, Type outputType, out int usedBytes) {
      usedBytes = 0;
      var typeData = TypeData.GetTypeData(outputType);
      var instance = typeData.GetInstance();
      var objectStack = new Stack();
      objectStack.Push(instance);
      var unclosedNodes = 0;
      usedBytes = memory.Length;
      foreach (var (Name, serializingType, Content) in new FileDB(memory).EnumerateTree()) {
        object currentObject;
        MemberData member;
        switch (serializingType) {
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
              _ = typeData.UnorderedNodes.TryGetValue(Name, out member);
              //Not required
              if (member == null) {
                unclosedNodes++;
              }
              //Serialize data
              else {
                var memberTypeData = TypeData.GetTypeData(member.Type);
                object memberObject = null;

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
                    _ = list.Add(memberObject);
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
              _ = objectStack.Pop();
            break;

          // Attribute
          case SerializingType.Content:
            currentObject = objectStack.Peek();
            typeData = TypeData.GetTypeData(currentObject.GetType());

            //Find matching member
            _ = typeData.UnorderedAttributes.TryGetValue(Name, out member);
            if (member != null) {
              ReadMember(currentObject, member, in Content, out var _);
              break;
            }
            break;

          default:
            break;
        }
      }
      return instance;
    }

    #endregion Public Methods

    #region Private Methods

    private static void ReadMember(object instance, MemberData member, in ReadOnlyMemory<byte> content, out int usedBytes) {
      usedBytes = 0;
      object value;
      var elementType = member.Type.GetFirstUnderlayingType();
      try {
        //Handle Arrays
        if (member.Type.IsArray) {
          var values = Array.CreateInstance(elementType, member.Attribute.Length);
          for (var i = 0; i < values.Length; i++) {
            var reader = content.ToReader();
            values.SetValue(reader.ReadObject(out var usedB, elementType, member.Attribute), i);
            usedBytes += usedB;
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
            _ = list.Add(content.ReadObject(out var usedB, elementType, member.Attribute));
            usedBytes += usedB;
          }
          else {
            value = content.ReadObject(out var usedB, member.Type, member.Attribute);
            usedBytes = usedB;
            member.MemberInfo.SetMemberValue(instance, value);
          }
          return;
        }
        else {
          value = content.ReadObject(out var usedB, member.Type, member.Attribute);
          usedBytes += usedB;
        }

        member.MemberInfo.SetMemberValue(instance, value);
      }
      catch (Exception) {
        System.Diagnostics.Debug.WriteLine($"Something is wrong with the member Name:{member.Attribute.Name} Type:{member.Type.ToTypeString()} in Class:{instance.GetType().ToTypeString()}");
      }
    }

    #endregion Private Methods
  }
}