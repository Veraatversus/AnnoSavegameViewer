// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace ClassCreator.Serialization.Tree {

  using System;
  using System.Collections;
  using System.Collections.Generic;
  using System.Collections.ObjectModel;
  using System.Collections.Specialized;
  using System.Drawing;
  using System.Linq;
  using AnnoSerializer.Serialization.Core;
  using ClassCreator.Serialization.Pattern;

  public class TreeChildCollection : ICollection<TreeNode>/*, INotifyCollectionChanged*/ {

    #region Public Properties

    public TreeNode Parent { get; set; }
    public bool HasChilds => Count > 0;
    public int Count => Nodes?.Count ?? 0 + Attributes?.Count ?? 0 + ((Keys?.ChildsCollection?.HasChilds ?? false) ? 1 : 0) + ((Values?.ChildsCollection?.HasChilds ?? false) ? 1 : 0);
    public bool IsReadOnly => ((ICollection<TreeNode>)Nodes).IsReadOnly && ((ICollection<TreeNode>)Attributes).IsReadOnly;

    //public IEnumerable<TreeNode> Items {
    //  get {
    //    for (var en = GetEnumerator(); en.MoveNext();) {
    //      yield return en.Current;
    //    }
    //  }
    //}
    #endregion Public Properties

    #region Public Events

    //public event NotifyCollectionChangedEventHandler CollectionChanged;

    #endregion Public Events

    #region Public Constructors

    public TreeChildCollection(TreeNode parent) {
      Parent = parent;
      //Nodes.CollectionChanged += OnCollectionChanged;
      //Attributes.CollectionChanged += OnCollectionChanged;
    }

    #endregion Public Constructors

    #region Public Methods
    public void Add(TreeNode item) => Add(item, true);
    public void Add(TreeNode item, bool spiltNones = true) {
      //var name = item.Name.Replace(".", "_", System.StringComparison.Ordinal).Replace(" ", "_", System.StringComparison.Ordinal);
      if (item.NodeType == BinaryContentTypes.Attribute) {
        if (item.Name is "None" && spiltNones) {
          InitKeys();
          Keys!.AddChild(item, false);
        }
        else {
          //if (Parent.ClassName.Count > 0) {
          //  item.ClassName.AddRange(Parent.ClassName);
          //}
          //item.ClassName.Add(item.Name);
          item.ClassName = new ClassName(Parent.ClassName, item.Name);
          PatternService.Default.SetPatternOrDefault(item);
          (Attributes ??= new HashSet<TreeNode>()).Add(item);
        }
      }
      else if (item.Name is "None" && spiltNones) {
        InitValues();
        Values!.AddChild(item, false);
      }
      else {
        //if (Parent.ClassName.Count > 0) {
        //  item.ClassName.AddRange(Parent.ClassName);
        //}
        //item.ClassName.Add(item.Name);
        item.ClassName = new ClassName(Parent.ClassName, item.Name);
        PatternService.Default.SetPatternOrDefault(item);
        (Nodes ??= new HashSet<TreeNode>()).Add(item);
      }
    }

    public void Clear() {
      foreach (var node in (Attributes ?? Enumerable.Empty<TreeNode>()).Concat(Nodes ?? Enumerable.Empty<TreeNode>())) {
        node.UnregisterFromPattern();
      }

      Attributes?.Clear();
      Nodes?.Clear();

      if (Keys is not null) {
        Keys.UnregisterFromPattern();
        Keys = null;
      }

      if (Values is not null) {
        Values.UnregisterFromPattern();
        Values = null;
      }
    }

    public bool Contains(TreeNode item) => (Attributes?.Contains(item) ?? false) || (Nodes?.Contains(item) ?? false) || (Keys?.ChildsCollection?.Contains(item) ?? false) || (Values?.ChildsCollection?.Contains(item) ?? false);

    public void CopyTo(TreeNode[] array, int arrayIndex) => (Attributes ?? Enumerable.Empty<TreeNode>()).Concat(Nodes ?? Enumerable.Empty<TreeNode>()).Concat(Keys?.ChildsCollection ?? Enumerable.Empty<TreeNode>()).Concat(Values?.ChildsCollection ?? Enumerable.Empty<TreeNode>()).ToList().CopyTo(array, arrayIndex);

    public IEnumerator<TreeNode> GetEnumerator() {
      foreach (var item in (Attributes ?? Enumerable.Empty<TreeNode>()).Concat(Nodes ?? Enumerable.Empty<TreeNode>()).Concat(Keys != null ? new[] { Keys } : Enumerable.Empty<TreeNode>()).Concat(Values != null ? new[] { Values } : Enumerable.Empty<TreeNode>())) {
        yield return item;
      }
    }

    public bool Remove(TreeNode item) {
      var removed = false;
      if (item.NodeType == BinaryContentTypes.Attribute) {
        removed = (Attributes?.Remove(item) ?? false) || (Keys?.ChildsCollection?.Remove(item) ?? false) || (Values?.ChildsCollection?.Remove(item) ?? false);
      }
      else {
        removed = (Nodes?.Remove(item) ?? false) || (Keys?.ChildsCollection?.Remove(item) ?? false) || (Values?.ChildsCollection?.Remove(item) ?? false);
      }
      if (removed) {
        item.UnregisterFromPattern();
      }
      return removed;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    #endregion Public Methods

    #region Private Properties

    private HashSet<TreeNode> Nodes { get; set; }

    private HashSet<TreeNode> Attributes { get; set; }

    #endregion Private Properties

    #region Private Methods

    private void InitValues() {
      if (Values == null) {
        Values = new TreeNode("Values") {
          NodeType = BinaryContentTypes.Node,
          //ClassName = $"{Parent?.ClassName ?? ""}.Values",
        };
        //if (Parent.ClassName.Count > 0) {
        //  Values.ClassName.AddRange(Parent.ClassName);
        //}
        //Values.ClassName.Add(Values.Name);
        Values.ClassName = new ClassName(Parent.ClassName, Values.Name);
        PatternService.Default.SetPatternOrDefault(Values);
        Values.Pattern.IsArrayItem = true;
        Values.Pattern.Attribute.Name = "None";
      }
    }

    private void InitKeys() {
      if (Keys == null) {
        Keys = new TreeNode("Keys") {
          NodeType = BinaryContentTypes.Attribute
        };

        //if (Parent.ClassName.Count > 0) {
        //  Keys.ClassName.AddRange(Parent.ClassName);
        //}
        //Keys.ClassName.Add(Keys.Name);
        Keys.ClassName = new ClassName(Parent.ClassName, Keys.Name);
        PatternService.Default.SetPatternOrDefault(Keys);
        Keys.Pattern.IsArrayItem = true;
        Keys.Pattern.Attribute.Name = "None";
      }
    }

    #endregion Private Methods

    #region Private Fields

    private TreeNode Keys;
    private TreeNode Values;

    #endregion Private Fields
  }
}