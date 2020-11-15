using AnnoSavegameViewer.Serialization.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AnnoSavegameViewer.Helper.TreeNode {

  public class TreeNode : IEnumerable<TreeNode> {

    #region Public Properties

    public ushort Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public TreeNode Parent { get; set; }

    public LinkedList<TreeNode> Nodes { get; set; } = new LinkedList<TreeNode>();

    public LinkedList<TreeNode> Attributes { get; set; } = new LinkedList<TreeNode>();

    public ReadOnlyMemory<byte> Content { get; set; }

    public BinaryContentTypes NodeType { get; set; }

    public bool IsArrayItem { get; internal set; }

    public string ClassName { get; set; }

    #endregion Public Properties

    #region Public Indexers

    //  Name = treeNode.Name;
    //  Id = treeNode.Id;
    //  Parent = treeNode.Parent;
    //  Nodes = new LinkedList<TreeNode>(treeNode.Nodes.Select(n => new TreeNode(n)));
    //  Attributes = new LinkedList<TreeNode>(treeNode.Attributes.Select(n => new TreeNode(n)));
    //  Content = treeNode.Content;
    //  NodeType = treeNode.NodeType;
    //  IsArrayItem = treeNode.IsArrayItem;
    //}
    public TreeNode[] this[string tag] { get => Nodes.ToLookup(x => x.Name, x => x)[tag].ToArray(); }

    #endregion Public Indexers

    #region Public Constructors

    public TreeNode() {
    }

    #endregion Public Constructors

    #region Public Methods

    //public TreeNode(TreeNode treeNode) {
    //  if (treeNode == null)
    //    throw new ArgumentNullException(nameof(treeNode));
    //public TreeNode this[int index] { get => Nodes[index]; }
    public void SetArrayItems() {
      foreach (var item in Nodes.ToLookup(x => x.Name).Where(g => g.Skip(1).Any()).SelectMany(g => g)) {
        item.IsArrayItem = true;
      }
      foreach (var item in Attributes.ToLookup(x => x.Name).Where(g => g.Skip(1).Any()).SelectMany(g => g)) {
        item.IsArrayItem = true;
      }
    }

    public void AddChild(TreeNode element) {
      if (element is null) {
        throw new ArgumentNullException(nameof(element));
      }
      element.Parent = this;
      Nodes.AddLast(element);
    }

    public void AddAttribute(TreeNode element) {
      if (element is null) {
        throw new ArgumentNullException(nameof(element));
      }
      element.Parent = this;
      Attributes.AddLast(element);
    }

    public IEnumerator<TreeNode> GetEnumerator() {
      return Nodes.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator() {
      return GetEnumerator();
    }

    #endregion Public Methods
  }
}