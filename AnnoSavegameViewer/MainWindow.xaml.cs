namespace AnnoSavegameViewer {
  using AnnoSavegameViewer.Controls;
  using AnnoSavegameViewer.Controls.Loading;
  using AnnoSavegameViewer.Templates;
  using Microsoft.Win32;
  using System;
  using System.ComponentModel;
  using System.Runtime.CompilerServices;
  using System.Windows;

  /// <summary> Interaction logic for MainWindow.xaml </summary>
  public partial class MainWindow : Window {

    #region Public Events

    public event Action SaveGameChanged;

    #endregion Public Events

    #region Public Constructors

    public MainWindow() {
      ProgrammSettings.MainWindow = this;
      InitializeComponent();
      Loaded += MainWindow_Loaded;
      DataContext = this;
      ComboBoxLanguage.SelectedItem = ProgrammSettings.Language;
      ComboBoxLanguage.SelectionChanged += ComboBoxLanguage_SelectionChanged;
    }

    #endregion Public Constructors

    #region Private Methods

    private void MainWindow_Loaded(object sender, RoutedEventArgs e) => cbMode.SelectedIndex = 0;

    private void ComboBoxLanguage_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e) {
      if (ComboBoxLanguage.SelectedItem is Languages lang) {
        ProgrammSettings.Language = lang;
      }
      DataContext = null;
      DataContext = this;
    }

    private void cbMode_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e) {
      if (Presenter != null) {
        switch (cbMode.SelectedIndex) {
          case 0:
            Presenter.Content = new SavegameItemsView();
            break;

          case 1:
            Presenter.Content = new SavegameBuildingsView();
            break;

          case 2:
            Presenter.Content = new SavegameUpgradesView();
            break;

          default:
            break;
        }
      }
    }

    private async void btnLoadSavegame_Click(object sender, RoutedEventArgs e) {
      var dialog = new OpenFileDialog { Filter = "Savegames (*.A7S)|*.A7S|All files (*.*)|*.*" };
      if (dialog.ShowDialog() == true) {
        var loadingDialog = new LoadingDialog() { Owner = this };
        loadingDialog.Show();
        await SaveGameReader.ReadFileAsync(dialog.FileName);
        SaveGameChanged?.Invoke();
        loadingDialog.Close();
      }
    }

    #endregion Private Methods
  }
}