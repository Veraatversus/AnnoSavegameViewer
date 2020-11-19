// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSavegameViewer.Templates.Filters {
  using System;
  using System.Collections.Generic;
  using System.Globalization;
  using System.Linq;

  public class SearchTextFilter : BaseFilter<string> {

    #region Public Properties

    public override Func<IEnumerable<AnnoItem>, IEnumerable<AnnoItem>> FilterFunc => result => {
      return !string.IsNullOrEmpty(SelectedValue)
        ? result.Where(w => w.GUID.GUID.ToString(CultureInfo.CurrentCulture).StartsWith(SelectedValue, StringComparison.InvariantCultureIgnoreCase) || w.GUID.CurrentLang.Contains(SelectedValue, StringComparison.CurrentCultureIgnoreCase))
        : null;
    };

    public override int DescriptionID => -100013;

    public override string SelectedValue {
      get => _selectedValue;
      set {
        if (!(_selectedValue?.Equals(value, StringComparison.CurrentCulture) ?? false)) {
          _selectedValue = value;
          UpdateSavedItems();
          RaisePropertyChanged();
        }
      }
    }

    #endregion Public Properties

    #region Public Constructors

    public SearchTextFilter(ItemsHolder itemsHolder) : base(itemsHolder) => FilterType = FilterType.Text;

    #endregion Public Constructors

    #region Private Fields

    private string _selectedValue;

    #endregion Private Fields
  }
}