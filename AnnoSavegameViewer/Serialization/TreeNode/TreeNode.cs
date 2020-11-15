namespace AnnoSavegameViewer.Serialization.Tree {
  using AnnoSavegameViewer.Serialization.Core;
  using AnnoSavegameViewer.Serialization.Memory;
  using AnnoSavegameViewer.Serialization.Pattern;
  using AnnoSavegameViewer.Structures.FileDB;
  using AnnoSavegameViewer.Structures.RDA;
  using System;
  using System.Collections;
  using System.Collections.Generic;
  using System.ComponentModel;
  using System.Runtime.CompilerServices;

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
          if (Pattern != null && Guid != default) {
            _ = Pattern.RegisteredNodes.Remove(Guid);
            Guid = default;
          }
          Pattern = PatternService.Default.GetValueOrDefault(this);
          RaisePropertyChanged(nameof(ClassName));
        }
      }
    }

    public PropertyPattern Pattern { get; set; }

    public object CalculatedValue {
      get => GetCalculatedValue();
      set => calculatedValue = value;
    }

    public Guid Guid { get; set; }

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
        try {
          switch (oldConversationType) {
            case ConversationTypes.None:
              Childs.Clear();
              var type = Pattern.ValueType;
              if (Pattern.GenericType != null) {
                type = Pattern.GenericType.MakeGenericType(Pattern.ValueType);
              }
              calculatedValue = Content.ReadObject(out _, type, Pattern.Attribute);
              break;

            case ConversationTypes.RDA:
              Childs.Clear();
              var reader = new MemoryReader(Content.ReadObject<ReadOnlyMemory<byte>>(Pattern.Attribute));
              var rda = new Rda(ref reader);
              rda.ReadBinaryNode(this);
              break;

            case ConversationTypes.FileDB:
              Childs.Clear();
              var fileDB = new FileDB(Content.ReadObject<ReadOnlyMemory<byte>>(Pattern.Attribute));
              fileDB.ReadBinaryNode(this);
              break;
          }
        }
        catch (Exception) {
          //Conversation Failed. return default
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

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    #endregion Public Methods

    #region Private Destructors

    ~TreeNode() {
      _ = (Pattern?.RegisteredNodes.Remove(Guid));
    }

    #endregion Private Destructors

    #region Private Fields

    private BinaryContentTypes nodeType;
    [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0052:Ungelesene private Member entfernen", Justification = "<Ausstehend>")]
    private object calculatedValue;
    private string className = string.Empty;

    #endregion Private Fields
  }
}