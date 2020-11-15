namespace AnnoSavegameViewer.Serialization.Tree {
  using AnnoSavegameViewer.Serialization.Core;
  using AnnoSavegameViewer.Structures.FileDB;
  using AnnoSavegameViewer.Structures.RDA;
  using System;
  using System.Collections.Generic;
  using System.Threading.Tasks;
  using System.Xml.Linq;
  using MemoryExtensions = AnnoSavegameViewer.Serialization.Memory.MemoryExtensions;

  public static partial class TreeNodeExtensions {

    #region Public Methods

    public static Task SaveXml(this TreeNode node, string path) {
      return Task.Run(() => {
        //Directory.CreateDirectory(path);
        var rootxml = node.ToXml();
        rootxml.Save(path);
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

    public static async Task<TreeNode> ReadBinaryNode(this Rda rda, TreeNode treeNode = null, string baseNodeName = null) {
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
        foreach (var file in rda.Blocks[i].Files) {
          var fileNode = new TreeNode(file.FileHeader.FilePath) {
            NodeType = BinaryContentTypes.Node,
            Content = file.FileData
          };
          blockNode.AddChild(fileNode);
          fileNode.Pattern.Attribute.RdaFile = file.FileHeader.FilePath;
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