// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSavegameViewer.ViewModels {
  using AnnoSerializer.Structures.DataTypes;
  using AnnoSavegameViewer.Templates;
  using System.ComponentModel;
  using System.Linq;
  using System.Runtime.CompilerServices;

  public class SavegameItemsViewModel : INotifyPropertyChanged {

    #region Public Properties

    public ItemsHolder ItemsHolder { get; }

    public IGrouping<AnnoItem, AnnoItem> SelectedItem {
      get => selectedItem;
      set {
        if (selectedItem != value) {
          selectedItem = value;
          RaisePropertyChanged();
          ItemsHolder.SelectedItemTree = new[] { TreeWorld.Create(new DescriptionInt(-100030), SelectedItem) };
        }
      }
    }

    #endregion Public Properties

    #region Public Events

    public event PropertyChangedEventHandler PropertyChanged;

    #endregion Public Events

    #region Public Constructors

    public SavegameItemsViewModel(ItemsHolder itemsholder) => ItemsHolder = itemsholder;

    #endregion Public Constructors

    #region Public Methods

    public void RaisePropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    #endregion Public Methods

    #region Private Fields

    private IGrouping<AnnoItem, AnnoItem> selectedItem;

    #endregion Private Fields
  }
}