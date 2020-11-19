// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.FileDB {
  using AnnoSerializer.Serialization.Core;
  using AnnoSerializer.Serialization.Memory;
  using System;
  using System.Collections.Generic;
  using System.Runtime.InteropServices;

  public class FileDB {

    #region Public Properties

    public ReadOnlyMemory<byte> Memory { get; }
    public bool IsCompressed { get; }

    #endregion Public Properties

    #region Public Constructors

    public FileDB(ReadOnlyMemory<byte> memory) => Memory = memory;

    #endregion Public Constructors

    #region Public Methods

    public IEnumerable<(string Name, SerializingType serializingType, ReadOnlyMemory<byte> Content)> EnumerateTree() {
      var reader = new MemoryReader(Memory);

      //Set Position from The Tags Section
      var TagsOff = reader.Position = System.Convert.ToInt32(MemoryMarshal.Read<uint>(reader.Memory.Span[^4..]));

      //Read Tags
      var tags = GetTagDictionary(ref reader);

      //Array Elements
      tags.Add(1, "None");
      tags.Add(32768, "None");
      foreach (var item in EnumerateNodes(reader.Memory, tags, TagsOff)) {
        yield return item;
      }
    }

    #endregion Public Methods

    #region Private Methods

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

    private static IEnumerable<(string Name, SerializingType serializingType, ReadOnlyMemory<byte> Content)> EnumerateNodes(ReadOnlyMemory<byte> memory, Dictionary<ushort, string> tags, int tagsOffset) {
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
            if (tag.StartsWith("AreaManager_")) {
              tag = "None";
            }
            yield return (tag, SerializingType.OpenNode, default);
          }

          //Attribute
          else {
            length = reader.ReadInt32Bit7();
            yield return (tag, SerializingType.Content, reader.Memory.Slice(reader.Position, length));
            reader.Position += length;
          }
        }
      }
    }

    #endregion Private Methods
  }
}