namespace AnnoSavegameViewer.Templates.Filters {
  using System;
  using System.Collections.Generic;
  using System.ComponentModel;
  using System.Runtime.CompilerServices;

  public interface IFilter<T> : IFilter {

    #region Public Properties

    new T SelectedValue { get; set; }

    new List<T> CurrentValues { get; }

    #endregion Public Properties

    #region Public Methods

    new void RaisePropertyChanged([CallerMemberName] string name = "");

    #endregion Public Methods
  }

  public interface IFilter : INotifyPropertyChanged {

    #region Public Properties

    object SelectedValue { get; }
    Func<IEnumerable<AnnoItem>, IEnumerable<AnnoItem>> FilterFunc { get; }
    List<object> CurrentValues { get; }

    string Description { get; }

    FilterType FilterType { get; set; }

    List<AnnoItem> SavedItems { get; set; }

    #endregion Public Properties

    #region Public Methods

    void UpdateUI();

    void ResetFilter();

    void UpdateSavedItems();

    #endregion Public Methods
  }
}