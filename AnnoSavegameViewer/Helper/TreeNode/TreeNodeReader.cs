using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Serialization.FileDBSerializer;
using AnnoSavegameViewer.Serialization.Memory;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AnnoSavegameViewer.Helper.TreeNode {

  public static class TreeNodeReader {
    //public static void ReadBinaryNode(this ReadOnlyMemory<byte> memory, out TreeNode node) {
    //  var Filereader = new SpanReader(memory, Endian.Little);
    //  node = new TreeNode { Name = "BaseNode" };

    // //Check Compression if (Filereader.ReadInt16() == -9608) { Filereader = new
    // SpanReader(memory.Span.ZlibDecompress(), Endian.Little); }

    // //Set Position from The Tags Section var TagsOff = Filereader.Position = Convert.ToInt32(MemoryMarshal.Read<UInt32>(Filereader.Span[^4..]));

    // //Read Tags var tags = FileDBSerializer.GetTagDictionary(ref Filereader);

    // //Array Elements tags.Add(1, "None"); tags.Add(32768, "None");

    //  //Get Nodes Section
    //  var nodesReader = new SpanReader(Filereader.Memory[..TagsOff], Endian.Little);
    //  ReadNodes(ref nodesReader, tags, node);
    //}

    #region Public Methods

    public static async Task<TreeNode> ReadBinaryNode(this ReadOnlyMemory<byte> memory, TreeNode treeNode = null) {
      var mainNode = treeNode ?? new TreeNode() { Name = "BaseNode" };
      var currentNode = mainNode;
      await foreach (var item in FileDBSerializer.EnumerateTreeAsync(memory)) {
        switch (item.Item2/*.serializingType*/) {
          case SerializingType.OpenNode:
            var newNode = new TreeNode() { Name = item.Item1/*.Name*/, Parent = currentNode, NodeType = BinaryContentTypes.Node };
            currentNode.Nodes.AddLast(newNode);
            currentNode = newNode;
            break;

          case SerializingType.CloseNode:
            currentNode = currentNode.Parent;
            break;

          case SerializingType.Content:
            var newAttribute = new TreeNode() {
              Name = item.Item1/*.Name*/,
              Parent = currentNode,
              NodeType = BinaryContentTypes.Attribute,
              Content = item.Item3/*.Content*/
            };

            currentNode.Attributes.AddLast(newAttribute);
            break;
        }
      }
      return mainNode;
    }

    #endregion Public Methods

    #region Private Methods

    private async static void ReadNodes(MemoryReader nodesReader, Dictionary<ushort, string> tags, TreeNode currentNode) {
      while (nodesReader.Position < nodesReader.Length) {
        //Get Next ID
        var nextId = nodesReader.ReadUInt16();

        //Close Node
        if (nextId == 0) {
          currentNode = currentNode.Parent;
        }

        //Check for Existing Id
        else if (tags.TryGetValue(nextId, out var tag)) {
          //Node
          if (nextId < 32768) {
            var node = new TreeNode { Id = nextId, Name = tag };
            currentNode.AddChild(node);
            currentNode = node;
          }

          //Attribute
          else {
            var length = nodesReader.ReadInt32Bit7();

            //Extract Sub Nodes
            if (tag == "BinaryData") {
              var node = await ReadBinaryNode(nodesReader.Memory.Slice(nodesReader.Position, length));
              node.Name = tag;
              node.Id = nextId;
              currentNode.AddChild(node);
            }

            //Read Normal Attribute
            else {
              currentNode.Attributes.AddLast(new TreeNode {
                NodeType = BinaryContentTypes.Attribute,
                Id = nextId,
                Name = tag,
                Content = nodesReader.Memory.Slice(nodesReader.Position, length)
              });
            }
            nodesReader.Position += length;
          }
        }
      }
    }

    #endregion Private Methods
  }
}