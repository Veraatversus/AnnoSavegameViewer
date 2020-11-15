namespace AnnoSavegameViewer.Controls {
  using AnnoSavegameViewer.Templates;
  using AnnoSavegameViewer.ViewModels;
  using System;
  using System.Linq;
  using System.Windows;
  using System.Windows.Controls;

  /// <summary> Interaktionslogik für SavegameItemsView.xaml </summary>
  public partial class SavegameBuildingsView : UserControl {

    #region Public Properties

    public SavegameItemsViewModel ViewModel { get; set; } = new SavegameItemsViewModel(new BuildingsHolderItems());

    #endregion Public Properties

    #region Public Constructors

    public SavegameBuildingsView() {
      InitializeComponent();
      DataContext = ViewModel;
      Loaded += SavegameItemsView_Loaded;
      Unloaded += SavegameItemsView_Unloaded;
    }

    #endregion Public Constructors

    #region Public Methods

    public void BtnResetFilters_Click(object sender, RoutedEventArgs e) => ViewModel.ItemsHolder.ResetFilters();

    public void ComboBox_SelectionChanged(object sender, EventArgs e) => UpdateUi();

    #endregion Public Methods

    #region Private Methods

    private void SavegameItemsView_Unloaded(object sender, RoutedEventArgs e) {
      ProgrammSettings.MainWindow.SaveGameChanged -= MainWindow_SaveGameChanged;
      ProgrammSettings.OnLanguageChanged -= ProgrammSettings_OnLanguageChanged;
    }

    private void SavegameItemsView_Loaded(object sender, RoutedEventArgs e) {
      ProgrammSettings.MainWindow.SaveGameChanged += MainWindow_SaveGameChanged;
      ProgrammSettings.OnLanguageChanged += ProgrammSettings_OnLanguageChanged;
      UpdateUi();
    }

    private void ProgrammSettings_OnLanguageChanged() {
      DataContext = null;
      DataContext = ViewModel;
    }

    private void MainWindow_SaveGameChanged() => UpdateUi();

    private void UpdateUi() {
      ViewModel.ItemsHolder.UpdateUI();
      if (!ViewModel.ItemsHolder.IsRefreshingUi && ViewModel.SelectedItem != null) {
        ViewModel.SelectedItem = ViewModel.ItemsHolder.Items.FirstOrDefault();
      }
    }

    #endregion Private Methods
  }
}