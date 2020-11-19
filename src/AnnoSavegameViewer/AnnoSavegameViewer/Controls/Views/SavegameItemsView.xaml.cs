// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSavegameViewer.Controls {

  using System;
  using System.Linq;
  using System.Windows;
  using System.Windows.Controls;
  using AnnoSavegameViewer.Templates;
  using AnnoSavegameViewer.ViewModels;
  using AnnoSerializer;

  /// <summary> Interaktionslogik für SavegameItemsView.xaml </summary>
  public partial class SavegameItemsView : UserControl {

    #region Public Properties

    public SavegameItemsViewModel ViewModel { get; set; } = new SavegameItemsViewModel(new ItemsHolderItems());

    #endregion Public Properties

    #region Public Constructors

    public SavegameItemsView() {
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
      LanguageService.OnLanguageChanged -= ProgrammSettings_OnLanguageChanged;
    }

    private void SavegameItemsView_Loaded(object sender, RoutedEventArgs e) {
      ProgrammSettings.MainWindow.SaveGameChanged += MainWindow_SaveGameChanged;
      LanguageService.OnLanguageChanged += ProgrammSettings_OnLanguageChanged;
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