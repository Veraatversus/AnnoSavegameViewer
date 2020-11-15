// Copyright © 2020 Vera@Versus. All rights reserved.
// Licensed under the MIT License.

namespace ClassCreator {
  using System;
  using System.Collections.Generic;
  using System.IO;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  using System.Windows.Input;
  using AnnoSavegameViewer.Serialization.Core;
  using AnnoSavegameViewer.Serialization.Pattern;
  using AnnoSavegameViewer.Serialization.Tree;
  using AnnoSavegameViewer.Structures.DataTypes;
  using AnnoSavegameViewer.Structures.Savegame;
  using Microsoft.Win32;
  using VAV;
  using VAV.Mvvm;

  public class ViewModel : ViewModelBase {

    #region Public Properties

    public ICommand LoadNewFileCommand { get; set; }
    public ICommand ResetAttributeCommand { get; set; }
    public ICommand ExportXmlCommand { get; set; }
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

    #endregion Public Properties

    #region Public Constructors

    public ViewModel() {
      LoadNewFileCommand = new AsyncRelayCommand(OnLoadNewFile);
      ResetAttributeCommand = new RelayCommand<TreeNode>(OnResetAttribute);
      ExportXmlCommand = new AsyncRelayCommand<TreeNode>(async (node) => await (node ?? Tree?.FirstOrDefault()).SaveXml(Path.GetFileNameWithoutExtension(FilePath) + ".xml"));
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

    private void OnResetAttribute(TreeNode arg) {
      if (arg != null) {
        arg.Pattern.GenericType = null;
        arg.Pattern.ValueType = typeof(HexString);
        arg.Pattern.Attribute.BoolPattern = default;
        arg.Pattern.Attribute.CompressionType = default;
        arg.Pattern.Attribute.ConversationType = default;
        arg.Pattern.Attribute.DateTimePattern = default;
        arg.Pattern.Attribute.Encoding = default;
        arg.Pattern.Attribute.Endian = default;
        arg.Pattern.Attribute.Length = default;
        arg.Pattern.Attribute.Offset = default;
        arg.Pattern.Attribute.StringPattern = default;
        arg.Pattern.Attribute.TimeSpanPattern = default;
      }
    }

    private async Task OnLoadNewFile() {
      var dialog = new OpenFileDialog();
      if (dialog.ShowDialog() == true && File.Exists(dialog.FileName)) {
        PatternService.Default.SavePatterns();
        _ = PatternService.Default.TryLoadPatterns(dialog.FileName);
        FilePath = dialog.FileName;
        var bytes = await File.ReadAllBytesAsync(dialog.FileName);
        Tree = new TreeChildCollection(null) { new TreeNode($"{PatternService.Default.Name}_File") { NodeType = BinaryContentTypes.Node, Content = bytes } };
      }
    }

    #endregion Private Methods

    #region Private Fields

    private TreeChildCollection tree;
    private TreeNode selectedValue;

    #endregion Private Fields
  }
}