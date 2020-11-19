// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace ClassCreator {
  using System.Windows;
  using ClassCreator.Serialization.Pattern;

  /// <summary> Interaction logic for MainWindow.xaml </summary>
  public partial class MainWindow : Window {

    #region Public Constructors

    public MainWindow() {
      InitializeComponent();
      DataContext = new ViewModel();
      Closed += MainWindow_Closed;
    }

    #endregion Public Constructors

    #region Private Methods

    private void MainWindow_Closed(object sender, System.EventArgs e) => PatternService.Default.SavePatterns();

    #endregion Private Methods
  }
}