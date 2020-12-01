// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace ClassCreator.Serialization.Tree {

  using System;
  using System.Collections;
  using System.Collections.Generic;
  using System.ComponentModel;
  using System.Runtime.CompilerServices;
  using System.Windows.Data;
  using AnnoSerializer.Serialization.Core;
  using AnnoSerializer.Serialization.Memory;
  using AnnoSerializer.Structures.FileDB;
  using AnnoSerializer.Structures.RDA;
  using ClassCreator.Serialization.Pattern;

  public class TreeNode : IEnumerable<TreeNode>, INotifyPropertyChanged {

    #region Public Properties

    public string Name { get; }

    public TreeChildCollection ChildsCollection { get; private set; }

    public ReadOnlyMemory<byte> Content { get; set; }

    public BinaryContentTypes NodeType {
      get => nodeType;
      set {
        if (nodeType != value) {
          nodeType = value;
          RaisePropertyChanged(nameof(NodeType));
        }
      }
    }

    public ClassName ClassName {
      get => className;
      set {
        if (className != value) {
          className = value;
          Pattern?.UnRegisterNode(this);
          PatternService.Default.SetPatternOrDefault(this);
          //RaisePropertyChanged(nameof(ClassName));
        }
      }
    }

    public PropertyPattern Pattern { get; set; }

    public object CalculatedValue {
      get => GetCalculatedValue();
      set => calculatedValue = value;
    }

    #endregion Public Properties

    #region Public Events

    public event PropertyChangedEventHandler PropertyChanged;

    #endregion Public Events

    #region Public Constructors

    public TreeNode(string name) {
      Name = name.Replace(".", "_");
      ChildsCollection = new TreeChildCollection(this);
    }

    #endregion Public Constructors

    #region Public Methods

    public void RaisePropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    public void AddChild(TreeNode element, bool splitNones = true) {
      if (element is null) {
        throw new ArgumentNullException(nameof(element));
      }
      ChildsCollection.Add(element, splitNones);
    }

    public IEnumerator<TreeNode> GetEnumerator() => ChildsCollection.GetEnumerator();

    public IEnumerable<TreeNode> Descendants(bool self = true) {
      if (self) {
        yield return this;
      }
      foreach (var child in ChildsCollection) {
        foreach (var descendant in child.Descendants()) {
          yield return descendant;
        }
      }
    }

    public IEnumerable<TreeNode> DescendantsThanSelf(bool self = true) { 
      foreach (var child in ChildsCollection) {
        foreach (var descendant in child.DescendantsThanSelf()) {
          yield return descendant;
        }
      }
      if (self) {
        yield return this;
      }
    }

    public object GetCalculatedValue() {
#pragma warning disable S1117 // Local variables should not shadow class fields
      object calculatedValue = null;  // No Keep Calculated Value
#pragma warning restore S1117 // Local variables should not shadow class fields

      if (calculatedValue is null && Content.Length is > 0) {
        var oldConversationType = Pattern.Attribute.ConversationType;
        Pattern.Attribute.conversationType = ConversationTypes.None;
        Clear();
        try {
          switch (oldConversationType) {
            case ConversationTypes.None:
              var type = Pattern.ValueType;
              if (Pattern.GenericType != null) {
                type = Pattern.GenericType.MakeGenericType(Pattern.ValueType);
              }
              calculatedValue = Content.ReadObject(out _, type, Pattern.Attribute);
              break;

            case ConversationTypes.RDA:
              var rda = new Rda(Content.ReadObject<ReadOnlyMemory<byte>>(Pattern.Attribute));
              rda.ReadBinaryNode(this);
              RefreshView();
              break;

            case ConversationTypes.FileDB:
              var fileDB = new FileDB(Content.ReadObject<ReadOnlyMemory<byte>>(Pattern.Attribute));
              fileDB.ReadBinaryNode(this);
              RefreshView();
              break;
          }
        }
        catch (Exception) {
          //Conversation Failed. return default
          System.Diagnostics.Debug.WriteLine($"Something went wrong with class: {ClassName}");
        }
        finally {
          Pattern.Attribute.conversationType = oldConversationType;
        }
      }
      return calculatedValue;
    }

    public void OnTypeChanged() {
      calculatedValue = null;
      RaisePropertyChanged(nameof(CalculatedValue));
    }

    public void UnregisterFromPattern() {
      foreach (var node in DescendantsThanSelf()) {
        node!.Pattern?.UnRegisterNode(node);
        node!.ChildsCollection.Parent = null;
        node!.ChildsCollection = null;
      }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public void Clear() {
      if (ChildsCollection.Count > 0) {
        ChildsCollection.Clear();
        RefreshView();
      }
    }

    public void RefreshView() => CollectionViewSource.GetDefaultView(this).Refresh();

    #endregion Public Methods

    #region Private Fields

    private BinaryContentTypes nodeType;

    [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0052:Ungelesene private Member entfernen", Justification = "<Ausstehend>")]
    private object calculatedValue;
    private ClassName className;

    #endregion Private Fields
  }
}