using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AnnoSavegameViewer.Templates.Filters {

  public interface IFilter<T> : IFilter {

    #region Public Properties

    new T SelectedValue { get; set; }

    //new T SelectedComparisonValue { get; set; }
    new List<T> CurrentValues { get; }

    #endregion Public Properties

    //new List<T> ComparisonValues { get; }

    #region Public Methods

    new void RaisePropertyChanged([CallerMemberName] string name = "");

    #endregion Public Methods
  }

  public interface IFilter : INotifyPropertyChanged {

    #region Public Properties

    object SelectedValue { get; }
    Func<IEnumerable<AnnoItem>, IEnumerable<AnnoItem>> FilterFunc { get; }
    List<object> CurrentValues { get; }

    //List<object> ComparisonValues { get; }
    string Description { get; }

    FilterType FilterType { get; set; }

    //FilterType ComparisonType { get; set; }
    //ValueComparisons Comparison { get; set; }
    //object SelectedComparisonValue { get; }
    List<AnnoItem> SavedItems { get; set; }

    #endregion Public Properties

    #region Public Methods

    void UpdateUI();

    void ResetFilter();

    void UpdateSavedItems();

    #endregion Public Methods

    //void SetCurrenValues();
  }
}