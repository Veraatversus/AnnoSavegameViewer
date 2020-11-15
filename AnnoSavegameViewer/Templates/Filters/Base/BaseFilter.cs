namespace AnnoSavegameViewer.Templates.Filters {
  using AnnoSavegameViewer.Structures.DataTypes;
  using System;
  using System.Collections.Generic;
  using System.ComponentModel;
  using System.Linq;
  using System.Runtime.CompilerServices;

  public abstract class BaseFilter<T> : IFilter<T> {

    #region Public Properties

    public FilterType FilterType { get; set; } = FilterType.Selection;

    public abstract int DescriptionID { get; }

    public virtual T SelectedValue {
      get => _selectedValue;
      set {
        if (!(_selectedValue?.Equals(value) ?? false) && value != null) {
          _selectedValue = value;
          UpdateSavedItems();
          RaisePropertyChanged();
        }
      }
    }

    public abstract Func<IEnumerable<AnnoItem>, IEnumerable<AnnoItem>> FilterFunc { get; }
    public virtual List<T> CurrentValues { get; set; }
    public ItemsHolder ItemsHolder { get; set; }

    public List<AnnoItem> SavedItems { get; set; }

    public virtual string Description => ProgrammSettings.Texts[DescriptionID];

    object IFilter.SelectedValue => SelectedValue;

    List<T> IFilter<T>.CurrentValues => CurrentValues;

    List<object> IFilter.CurrentValues => CurrentValues.Cast<object>().ToList();

    #endregion Public Properties


    #region Public Events

    public event PropertyChangedEventHandler PropertyChanged;

    #endregion Public Events

    #region Public Methods

    public void UpdateSavedItems() => SavedItems = FilterFunc(ItemsHolder.Base)?.ToList();

    public void RaisePropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    public void UpdateUI() {
      var item = SelectedValue;
      SetCurrenValues();
      RaisePropertyChanged(nameof(CurrentValues));

      if (item != null) {
        if (CurrentValues != null) {
          if (item is Description desc) {
            _selectedValue = CurrentValues.Find(v => (v as Description)?.Equals(item as Description) ?? false);
          }
          else {
            _selectedValue = CurrentValues.Find(v => v.Equals(item));
          }
        }
        else {
          _selectedValue = item;
        }
        RaisePropertyChanged(nameof(SelectedValue));
      }
    }

    public virtual void ResetFilter() => SelectedValue = CurrentValues != null ? CurrentValues.FirstOrDefault() : default;

    public virtual void SetCurrenValues() {
    }

    #endregion Public Methods

    #region Protected Constructors

    protected BaseFilter(ItemsHolder itemsHolder) {
      ItemsHolder = itemsHolder;
      SetCurrenValues();
    }

    #endregion Protected Constructors

    #region Private Fields

    private T _selectedValue;

    #endregion Private Fields

  }
}