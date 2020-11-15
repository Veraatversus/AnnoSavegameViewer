using AnnoSavegameViewer.Serialization.Core;
using System;
using System.Windows;
using System.Windows.Controls;

namespace ClassCreator {

  public class TreeNodeItemTemplateSelector : DataTemplateSelector {

    #region Public Methods

    public override DataTemplate SelectTemplate(object item, DependencyObject container) {
      if (item is TreeNode node) {
        string styleName = String.Empty;
        if (node.IsArrayItem) {
          styleName = "TreeNodeArrayTemplate";
        }
        else if (node.NodeType == BinaryContentTypes.Attribute) {
          styleName = "TreeNodeContentTemplate";
        }
        else {
          styleName = "TreeNodeObjectTemplate";
        }
        return Application.Current.TryFindResource(styleName) as DataTemplate;
      }
      return base.SelectTemplate(item, container);
    }

    #endregion Public Methods
  }
}