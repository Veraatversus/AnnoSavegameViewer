// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace ClassCreator.Serialization.Tree {

  using System;
  using System.Collections;
  using System.Collections.Generic;
  using System.ComponentModel;
  using System.Runtime.CompilerServices;
  using AnnoSerializer.Serialization.Core;
  using AnnoSerializer.Serialization.Memory;
  using AnnoSerializer.Structures.FileDB;
  using AnnoSerializer.Structures.RDA;
  using ClassCreator.Serialization.Pattern;

  public class TreeNode : IEnumerable<TreeNode>, INotifyPropertyChanged {

    #region Public Properties

    public ushort Id { get; set; }

    public string Name { get; }

    public TreeNode Parent { get; set; }

    public TreeChildCollection Childs { get; }

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

    public string ClassName {
      get => className;
      set {
        if (className != value) {
          className = value;
          Pattern?.UnRegisterNode(this);
          PatternService.Default.SetPatternOrDefault(this);
          RaisePropertyChanged(nameof(ClassName));
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
      Name = name;
      Childs = new TreeChildCollection(this);
    }

    #endregion Public Constructors

    #region Public Methods

    public void RaisePropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    public void AddChild(TreeNode element) {
      if (element is null) {
        throw new ArgumentNullException(nameof(element));
      }
      Childs.Add(element);
    }

    public IEnumerator<TreeNode> GetEnumerator() => Childs.GetEnumerator();

    public IEnumerable<TreeNode> Descendants(bool self = true) {
      if (self) {
        yield return this;
      }
      foreach (var child in Childs) {
        foreach (var descendant in child.Descendants()) {
          yield return descendant;
        }
      }
    }

    public object GetCalculatedValue() {
#pragma warning disable S1117 // Local variables should not shadow class fields
      object calculatedValue = null;  // No Keep Calculated Value
#pragma warning restore S1117 // Local variables should not shadow class fields

      if (calculatedValue is null && Content.Length is > 0) {
        var oldConversationType = Pattern.Attribute.ConversationType;
        Pattern.Attribute.conversationType = ConversationTypes.None;
        Childs.Clear();
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
              var reader = new MemoryReader(Content.ReadObject<ReadOnlyMemory<byte>>(Pattern.Attribute));
              var rda = new Rda(ref reader);
              rda.ReadBinaryNode(this);
              break;

            case ConversationTypes.FileDB:
              var fileDB = new FileDB(Content.ReadObject<ReadOnlyMemory<byte>>(Pattern.Attribute));
              fileDB.ReadBinaryNode(this);
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
      foreach (var node in Descendants()) {
        node?.Pattern?.UnRegisterNode(node);
      }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    #endregion Public Methods

    #region Private Fields

    private BinaryContentTypes nodeType;

    [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0052:Ungelesene private Member entfernen", Justification = "<Ausstehend>")]
    private object calculatedValue;
    private string className = string.Empty;

    #endregion Private Fields
  }
}