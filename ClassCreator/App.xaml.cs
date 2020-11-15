// Copyright © 2020 Vera@Versus. All rights reserved.
// Licensed under the MIT License.

namespace ClassCreator {
  using System.Globalization;
  using System.Windows;
  using System.Windows.Controls;
  using AnnoSavegameViewer.Converter;
  using AnnoSavegameViewer.Serialization.Tree;

  /// <summary> Interaction logic for App.xaml </summary>
  public partial class App : Application {

    #region Private Methods

    private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e) {
      if (sender is TextBox tb && !string.IsNullOrEmpty(tb.Text) && tb.Tag is TreeNode node) {
        try {
          node.CalculatedValue = StringParseConverter.TryParse(tb.Text, node.Pattern.FullType, CultureInfo.CurrentCulture);
        }
        catch (System.Exception) {
          node.CalculatedValue = null;
        }
      }
    }

    #endregion Private Methods
  }
}