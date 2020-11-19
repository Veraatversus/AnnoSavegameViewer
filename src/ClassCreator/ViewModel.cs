// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace ClassCreator {
  using System;
  using System.Collections.Generic;
  using System.IO;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  using System.Windows.Input;
  using AnnoSerializer.Serialization.Core;
  using ClassCreator.Serialization.Pattern;
  using ClassCreator.Serialization.Tree;
  using AnnoSerializer.Structures.DataTypes;
  using AnnoSerializer.Structures.Savegame;
  using Microsoft.Win32;
  using VAV;
  using VAV.Mvvm;

  public class ViewModel : ViewModelBase {

    #region Public Properties

    public ICommand LoadNewFileCommand { get; set; }
    public ICommand ResetAttributeCommand { get; set; }
    public ICommand ExportXmlCommand { get; set; }
    public ICommand ExportJsonCommand { get; set; }
    public ICommand ExportCSharpCommand { get; set; }
    public ICommand AnalysePatternsCommand { get; set; }
    public TreeNode SelectedValue {
      get => selectedValue;
      set {
        if (selectedValue != value) {
          selectedValue = value;
          RaisePropertyChanged(nameof(SelectedValue));
        }
      }
    }
    public TreeChildCollection Tree {
      get => tree;
      set {
        if (tree != value) {
          tree = value;
          RaisePropertyChanged(nameof(Tree));
        }
      }
    }

    public Type[] SupportedTypes { get; } = new[] {
      typeof(HexString),
      typeof(string),
      typeof(bool),
      typeof(sbyte),
      typeof(byte),
      typeof(short),
      typeof(ushort),
      typeof(int),
      typeof(uint),
      typeof(long),
      typeof(ulong),
      typeof(float),
      typeof(double),
      typeof(decimal),
      typeof(DateTime),
      typeof(TimeSpan),
      typeof(DescriptionInt),
      typeof(DescriptionShort),
      typeof(StateBits),
      typeof(ThreeStateEnum),
    };

    public Type[] GenericTypes { get; } = new[] {
      null,
      typeof(Point2D<>),
      typeof(Point3D<>),
      typeof(GenericList<>),
    };

    public List<string> Encodings { get; } = new List<string>();

    public string FilePath { get; set; }

    public IEnumerable<PropertyPattern> RootPatterns {
      get => rootPatterns;
      set {
        if (rootPatterns != value) {
          rootPatterns = value;
          RaisePropertyChanged(nameof(RootPatterns));
        }
      }
    }
    #endregion Public Properties

    #region Public Constructors

    public ViewModel() {
      LoadNewFileCommand = new AsyncRelayCommand(OnLoadNewFile);
      ResetAttributeCommand = new RelayCommand<PropertyPattern>(OnResetAttribute);
      ExportXmlCommand = new AsyncRelayCommand<TreeNode>(async (node) => await (node ?? Tree?.FirstOrDefault()).SaveXml(Path.GetFileNameWithoutExtension(FilePath) + ".xml"));
      ExportJsonCommand = new AsyncRelayCommand<TreeNode>(async (node) => await (node ?? Tree?.FirstOrDefault()).SaveJson(Path.GetFileNameWithoutExtension(FilePath) + ".json"));
      ExportCSharpCommand = new AsyncRelayCommand(PatternService.Default.SaveCSharpClasses);
      AnalysePatternsCommand = new AsyncRelayCommand(OnAnalysePatterns);
      Encodings.Add("");
      Encodings.AddRange(Encoding.GetEncodings().Select(e => e.Name));
    }

    #endregion Public Constructors

    #region Private Methods

    private async Task OnAnalysePatterns() {
      if (Tree?.FirstOrDefault() is TreeNode node) {
        await Task.Run(() => AnalyseNodePatterns(node));
      }
    }

    private void AnalyseNodePatterns(TreeNode treeNode, bool self = true) {
      foreach (var node in treeNode.Descendants(self).ToArray()) {
        if (node.Pattern.Attribute.ConversationType != ConversationTypes.None && !node.Childs.HasChilds) {
          _ = node.GetCalculatedValue();
          AnalyseNodePatterns(node, false);
          node.Childs.Clear();
        }
      }
    }

    private void OnResetAttribute(PropertyPattern pattern) {
      if (pattern != null) {
        pattern.GenericType = null;
        pattern.ValueType = typeof(HexString);
        pattern.Attribute.BoolPattern = default;
        pattern.Attribute.CompressionType = default;
        pattern.Attribute.ConversationType = default;
        pattern.Attribute.DateTimePattern = default;
        pattern.Attribute.Encoding = default;
        pattern.Attribute.Endian = default;
        pattern.Attribute.Length = default;
        pattern.Attribute.Offset = default;
        pattern.Attribute.StringPattern = default;
        pattern.Attribute.TimeSpanPattern = default;
      }
    }

    private async Task OnLoadNewFile() {
      var dialog = new OpenFileDialog();
      if (dialog.ShowDialog() == true && File.Exists(dialog.FileName)) {
        PatternService.Default.SavePatterns();
        _ = PatternService.Default.TryLoadPatterns(dialog.FileName);
        FilePath = dialog.FileName;
        var bytes = await File.ReadAllBytesAsync(dialog.FileName);
        Tree?.Clear();
        Tree = new TreeChildCollection(null);
        var rootNode = new TreeNode($"{PatternService.Default.Name}_File") { NodeType = BinaryContentTypes.Node, Content = bytes };
        Tree.Add(rootNode);
        RootPatterns = new[] { rootNode.Pattern };
      }
    }

    #endregion Private Methods

    #region Private Fields

    private TreeChildCollection tree;
    private TreeNode selectedValue;
    private IEnumerable<PropertyPattern> rootPatterns;

    #endregion Private Fields
  }
}