namespace AnnoSavegameViewer.Serialization.Pattern {
  using AnnoSavegameViewer.Serialization.Core;
  using AnnoSavegameViewer.Serialization.CSharp;
  using AnnoSavegameViewer.Serialization.Tree;
  using AnnoSavegameViewer.Structures.DataTypes;
  using Newtonsoft.Json;
  using System;
  using System.Collections.Generic;
  using System.ComponentModel;
  using System.Linq;
  using System.Runtime.CompilerServices;

  public class PropertyPattern : INotifyPropertyChanged {

    #region Public Properties

    public BinaryContentAttribute Attribute { get; set; }

    public string ClassName { get; set; }

    public Type ValueType {
      get => valueType;
      set {
        if (valueType != value) {
          valueType = value;
          RaisePropertyChanged(nameof(ValueType));
          OnAttributePropertyChanged(null, null);
        }
      }
    }

    public Type GenericType {
      get => genericType;
      set {
        if (genericType != value) {
          genericType = value;
          RaisePropertyChanged(nameof(GenericType));
          OnAttributePropertyChanged(null, null);
        }
      }
    }

    public bool IsArrayItem {
      get => isArrayItem;
      set {
        if (isArrayItem != value) {
          isArrayItem = value;
          RaisePropertyChanged(nameof(IsArrayItem));
        }
      }
    }

    [JsonIgnore]
    public Dictionary<Guid, WeakReference<TreeNode>> RegisteredNodes { get; } = new Dictionary<Guid, WeakReference<TreeNode>>();

    [JsonIgnore]
    public IEnumerable<PropertyPattern> Childs => PatternService.Default.Patterns.Values.Where(a => a.ClassName.StartsWith(ClassName + ".", StringComparison.Ordinal) && a.Depth == (Depth + 1));

    [JsonIgnore]
    public PropertyPattern Parent => PatternService.Default.Patterns.TryGetValue(ClassName.Remove(ClassName.LastIndexOf('.')), out var value) ? value : null;

    [JsonIgnore]
    public int Depth => ClassName?.Count(c => c == '.') ?? 0;

    [JsonIgnore]
    public Type FullType => GenericType != null ? GenericType.MakeGenericType(ValueType) : ValueType;

    [JsonIgnore]
    public string RealName => realName ??= ClassName.Remove(0, ClassName.LastIndexOf('.') + 1);

    [JsonIgnore]
    public bool IsRegistered { get; set; }

    [JsonIgnore]
    public CSharpClass Class => PatternService.Default.Classes.TryGetValue(ClassName, out var value) ? value : null;

    #endregion Public Properties

    #region Public Events

    public event PropertyChangedEventHandler PropertyChanged;

    #endregion Public Events

    #region Public Methods

    public void OnAttributePropertyChanged(object sender, PropertyChangedEventArgs e) => UpdateRegisteredNodes();

    public void RaisePropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    #endregion Public Methods

    #region Private Methods

    private void UpdateRegisteredNodes() {
      foreach (var reference in RegisteredNodes.ToArray()) {
        if (reference.Value.TryGetTarget(out var node)) {
          node.OnTypeChanged();
        }
        else {
          _ = RegisteredNodes.Remove(reference.Key);
        }
      }
    }

    #endregion Private Methods

    #region Private Fields

    private bool isArrayItem;
    private string realName;
    private Type valueType = typeof(HexString);
    private Type genericType = null;

    #endregion Private Fields
  }
}