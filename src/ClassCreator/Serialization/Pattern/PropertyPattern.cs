// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace ClassCreator.Serialization.Pattern {

  using System;
  using System.Collections.Generic;
  using System.ComponentModel;
  using System.Linq;
  using System.Runtime.CompilerServices;
  using AnnoSerializer.Serialization.Core;
  using ClassCreator.Serialization.CSharp;
  using ClassCreator.Serialization.Tree;
  using AnnoSerializer.Structures.DataTypes;
  using Newtonsoft.Json;

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
    public IEnumerable<PropertyPattern> Childs => PatternService.Default.Patterns.Values.Where(a => a.ClassName.StartsWith(ClassName + ".", StringComparison.Ordinal) && a.Depth == (Depth + 1));

    [JsonIgnore]
    public bool HasChilds => PatternService.Default.Patterns.Values.Any(a => a.ClassName.StartsWith(ClassName + ".", StringComparison.Ordinal) && a.Depth == (Depth + 1));

    [JsonIgnore]
    public TreeNode FirstRegisteredNode => registeredNodes.FirstOrDefault();

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

    public void UnRegisterNode(TreeNode node) => _ = registeredNodes.Remove(node);

    public void RegisterNode(TreeNode node) {
      node.Pattern = this;
      if (!registeredNodes.Contains(node)) {
        registeredNodes.Add(node);
      }
      if (registeredNodes.Count == 1) {
        RaisePropertyChanged(nameof(FirstRegisteredNode));
      }
    }

    #endregion Public Methods

    #region Private Methods

    private void UpdateRegisteredNodes() {
      foreach (var node in registeredNodes) {
        node.OnTypeChanged();
      }
    }

    #endregion Private Methods

    #region Private Fields

    [JsonIgnore]
    private readonly HashSet<TreeNode> registeredNodes = new HashSet<TreeNode>();
    private bool isArrayItem;
    private string realName;
    private Type valueType = typeof(HexString);
    private Type genericType = null;

    #endregion Private Fields
  }
}