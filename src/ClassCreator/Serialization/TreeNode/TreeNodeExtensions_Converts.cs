// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace ClassCreator.Serialization.Tree {

  using System;
  using System.IO;
  using System.Threading.Tasks;
  using System.Xml.Linq;
  using AnnoSerializer.Serialization.Core;
  using AnnoSerializer.Structures.FileDB;
  using AnnoSerializer.Structures.RDA;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Linq;
  using MemoryExtensions = AnnoSerializer.Serialization.Memory.MemoryExtensions;

  public static partial class TreeNodeExtensions {

    #region Public Methods

    public static Task SaveXml(this TreeNode node, string path) {
      return Task.Run(() => {
        var rootxml = node.ToXml();
        rootxml.Save(path);
      });
    }

    public static Task SaveJson(this TreeNode node, string path) {
      return Task.Run(() => {
        var rootjson = new JObject(node.ToJson());
        using var file = File.CreateText(path);
        using var writer = new JsonTextWriter(file);
        rootjson.WriteTo(writer);
      });
    }

    public static XElement ToXml(this TreeNode node) {
      var element = new XElement(node.Name.Replace(" ", "_", StringComparison.Ordinal));
      var value = node.CalculatedValue?.ToString() ?? MemoryExtensions.ToHexString(node.Content);
      if (node.Childs.HasChilds) {
        foreach (var item in node.Childs) {
          element.Add(item.ToXml());
        }
      }
      else {
        if (!node.Content.IsEmpty) {
          element.Value = value;
          return element;
        }
      }
      return element;
    }

    public static JProperty ToJson(this TreeNode node) {
      var element = new JProperty(node.Name.Replace(" ", "_", StringComparison.Ordinal));
      var value = node.CalculatedValue?.ToString() ?? MemoryExtensions.ToHexString(node.Content);
      if (node.Childs.HasChilds) {
        JContainer content = node.Pattern.IsArrayItem ? new JArray() : new JObject();
        element.Value = content;
        if (node.Pattern.IsArrayItem) {
          foreach (var item in node.Childs) {
            var val = item.ToJson();
            if (val.Name == "None") {
              content.Add(val.Value);
            }
            else {
              content.Add(new JObject(val));
            }
          }
        }
        else {
          foreach (var item in node.Childs) {
            content.Add(item.ToJson());
          }
        }
      }
      else {
        if (!node.Content.IsEmpty) {
          element.Value = value;
        }
      }
      return element;
    }

    public static TreeNode ReadBinaryNode(this Rda rda, TreeNode treeNode = null, string baseNodeName = null) {
      var mainNode = treeNode ?? new TreeNode(baseNodeName ?? "BaseNode");
      var rdaNode = new TreeNode($"{mainNode.Name}_RDA") { NodeType = BinaryContentTypes.Node };
      mainNode.AddChild(rdaNode);
      rdaNode.Pattern.Attribute = mainNode.Pattern.Attribute;
      //Blocks
      for (var i = 0; i < rda.Blocks.Count; i++) {
        var blockNode = new TreeNode($"Block {i.ToString().PadLeft(2, '0')}") {
          NodeType = BinaryContentTypes.Node,
        };
        rdaNode.AddChild(blockNode);
        blockNode.Pattern.Attribute.RdaBlock = i;
        //Files
        for (var i2 = 0; i2 < rda.Blocks[i].Files.Count; i2++) {
          var fileNode = new TreeNode(rda.Blocks[i].Files[i2].FileHeader.FilePath) {
            NodeType = BinaryContentTypes.Node,
            Content = rda.Blocks[i].Files[i2].FileData
          };
          blockNode.AddChild(fileNode);
          fileNode.Pattern.Attribute.RdaFile = rda.Blocks[i].Files[i2].FileHeader.FilePath;
        }
      }

      return rdaNode;
    }

    public static TreeNode ReadBinaryNode(this FileDB fileDB, TreeNode treeNode = null, string baseNodeName = null) {
      var mainNode = treeNode ?? new TreeNode(baseNodeName ?? "BaseNode");
      var currentNode = mainNode;
      foreach (var (Name, serializingType, Content) in fileDB.EnumerateTree()) {
        switch (serializingType) {
          case SerializingType.OpenNode:
            var newNode = new TreeNode(Name) { NodeType = BinaryContentTypes.Node };
            currentNode.AddChild(newNode);
            currentNode = newNode;
            break;

          case SerializingType.CloseNode:
            currentNode = currentNode.Parent;
            break;

          case SerializingType.Content:
            var newAttribute = new TreeNode(Name) {
              NodeType = BinaryContentTypes.Attribute,
              Content = Content
            };

            currentNode.AddChild(newAttribute);
            break;
        }
      }
      return mainNode;
    }

    #endregion Public Methods
  }
}