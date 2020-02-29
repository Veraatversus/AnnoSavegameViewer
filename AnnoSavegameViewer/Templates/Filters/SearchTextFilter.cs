using System;
using System.Collections.Generic;
using System.Linq;

namespace AnnoSavegameViewer.Templates.Filters {

  public class SearchTextFilter : BaseFilter<string> {

    #region Public Properties

    public override Func<IEnumerable<AnnoItem>, IEnumerable<AnnoItem>> FilterFunc => result => {
      if (!String.IsNullOrEmpty(SelectedValue)) {
        return result.Where(w => w.GUID.GUID.ToString().StartsWith(SelectedValue, StringComparison.InvariantCultureIgnoreCase) || w.GUID.CurrentLang.IndexOf(SelectedValue, StringComparison.CurrentCultureIgnoreCase) >= 0);
      }
      return null;
    };

    public override int DescriptionID => -100013;

    public override string SelectedValue {
      get {
        return _selectedValue;
      }
      set {
        if (!(_selectedValue?.Equals(value) ?? false)) {
          _selectedValue = value;
          UpdateSavedItems();
          RaisePropertyChanged();
        }
      }
    }

    #endregion Public Properties

    #region Public Constructors

    public SearchTextFilter(ItemsHolder itemsHolder) : base(itemsHolder) {
      FilterType = FilterType.Text;
    }

    #endregion Public Constructors

    #region Private Fields

    private string _selectedValue;

    #endregion Private Fields
  }
}