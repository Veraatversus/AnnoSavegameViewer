// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace ClassCreator.Serialization.Tree {

  using System;
  using System.Collections;
  using System.Collections.Generic;
  using System.Collections.ObjectModel;
  using System.Collections.Specialized;
  using System.Linq;
  using AnnoSerializer.Serialization.Core;

  public class TreeChildCollection : ICollection<TreeNode>, INotifyCollectionChanged {

    #region Public Properties

    public TreeNode Parent { get; set; }
    public bool HasChilds => Count > 0;
    public int Count => Nodes.Count + Attributes.Count + ((Keys?.Childs?.HasChilds ?? false) ? 1 : 0) + ((Values?.Childs?.HasChilds ?? false) ? 1 : 0);
    public bool IsReadOnly => ((ICollection<TreeNode>)Nodes).IsReadOnly && ((ICollection<TreeNode>)Attributes).IsReadOnly;

    #endregion Public Properties

    #region Public Events

    public event NotifyCollectionChangedEventHandler CollectionChanged;

    #endregion Public Events

    #region Public Constructors

    public TreeChildCollection(TreeNode parent) {
      Parent = parent;
      Nodes.CollectionChanged += OnCollectionChanged;
      Attributes.CollectionChanged += OnCollectionChanged;
    }

    #endregion Public Constructors

    #region Public Methods

    public void Add(TreeNode item) {
      item.Parent = Parent;
      var name = item.Name.Replace(".", "_", System.StringComparison.Ordinal).Replace(" ", "_", System.StringComparison.Ordinal);
      if (item.NodeType == BinaryContentTypes.Attribute) {
        if (name is "None") {
          InitKeys();
          item.ClassName = (Keys?.ClassName ?? "") + "." + name;
          Keys!.Childs.Attributes.Add(item);
        }
        else {
          item.ClassName = (Parent?.ClassName ?? "") + "." + name;
          Attributes.Add(item);
        }
      }
      else {
        if (name is "None") {
          InitValues();
          item.ClassName = (Values?.ClassName ?? "") + "." + name;
          Values!.Childs.Nodes.Add(item);
        }
        else {
          item.ClassName = (Parent?.ClassName ?? "") + "." + name;
          Nodes.Add(item);
        }
      }
    }

    public void Clear() {
      foreach (var node in Attributes.Concat(Nodes)) {
        node.UnregisterFromPattern();
      }

      Attributes.Clear();
      Nodes.Clear();

      if (Keys is not null) {
        Keys.UnregisterFromPattern();
        Keys = null;
      }

      if (Values is not null) {
        Values.UnregisterFromPattern();
        Values = null;
      }
    }

    public bool Contains(TreeNode item) => Attributes.Contains(item) || Nodes.Contains(item) || (Keys?.Childs?.Contains(item) ?? false) || (Values?.Childs?.Contains(item) ?? false);

    public void CopyTo(TreeNode[] array, int arrayIndex) => Attributes.Concat(Nodes).Concat(Keys?.Childs ?? Enumerable.Empty<TreeNode>()).Concat(Values?.Childs ?? Enumerable.Empty<TreeNode>()).ToList().CopyTo(array, arrayIndex);

    public IEnumerator<TreeNode> GetEnumerator() {
      foreach (var item in Attributes.Concat(Nodes).Concat(Keys != null ? new[] { Keys } : Enumerable.Empty<TreeNode>()).Concat(Values != null ? new[] { Values } : Enumerable.Empty<TreeNode>())) {
        yield return item;
      }
    }

    public bool Remove(TreeNode item) {
      var removed = false;
      if (item.NodeType == BinaryContentTypes.Attribute) {
        removed = Attributes.Remove(item) || (Keys?.Childs?.Remove(item) ?? false) || (Values?.Childs?.Remove(item) ?? false);
      }
      else {
        removed = Nodes.Remove(item) || (Keys?.Childs?.Remove(item) ?? false) || (Values?.Childs?.Remove(item) ?? false);
      }
      if (removed) {
        item.UnregisterFromPattern();
      }
      return removed;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    #endregion Public Methods

    #region Private Properties

    private ObservableCollection<TreeNode> Nodes { get; } = new ObservableCollection<TreeNode>();

    private ObservableCollection<TreeNode> Attributes { get; } = new ObservableCollection<TreeNode>();

    #endregion Private Properties

    #region Private Methods

    private void InitValues() {
      if (Values == null) {
        Values = new TreeNode("Values") {
          Parent = Parent,
          NodeType = BinaryContentTypes.Node,
          ClassName = (Parent?.ClassName ?? "") + ".Values",
        };
        Values.Pattern.IsArrayItem = true;
        Values.Pattern.Attribute.Name = "None";
      }
    }

    private void InitKeys() {
      if (Keys == null) {
        Keys = new TreeNode("Keys") {
          Parent = Parent,
          NodeType = BinaryContentTypes.Attribute,
          ClassName = (Parent?.ClassName ?? "") + ".Keys",
        };
        Keys.Pattern.IsArrayItem = true;
        Keys.Pattern.Attribute.Name = "None";
      }
    }

    private void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e) {
      try {
        CollectionChanged?.Invoke(sender, e);
      }
      catch (Exception) {
        //error while collectionChanged should not be called by other thread then created
      }
    }

    #endregion Private Methods

    #region Private Fields

    private TreeNode Keys;
    private TreeNode Values;

    #endregion Private Fields
  }
}