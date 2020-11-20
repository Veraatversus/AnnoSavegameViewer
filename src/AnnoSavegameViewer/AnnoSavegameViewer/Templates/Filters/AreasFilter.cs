// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSavegameViewer.Templates.Filters {
  using AnnoSerializer.Structures.DataTypes;
  using System;
  using System.Collections.Generic;
  using System.Linq;

  public class AreasFilter : BaseFilter<Description> {

    #region Properties

    public override Func<IEnumerable<AnnoItem>, IEnumerable<AnnoItem>> FilterFunc => result => {
      return SelectedValue != null && SelectedValue.GUID != 0
        ? result.Where(w => w.AreaInfo?.CityDescription?.CurrentLang?.Equals(SelectedValue.CurrentLang, StringComparison.CurrentCulture) == true)
        : null;
    };

    public override int DescriptionID => -100012;

    #endregion Properties

    #region Constructors

    public AreasFilter(ItemsHolder itemsHolder) : base(itemsHolder) => FilterType = FilterType.Selection;

    #endregion Constructors

    #region Methods

    public override void SetCurrenValues() {
      CurrentValues = ItemsHolder
         .GetResultWithoutFilter(this)
         .Where(s => s.AreaInfo != null)
         .Select(s => s.AreaInfo)
         .Distinct()
         .Select(s => s.CityDescription)
         .Concat(new[] { (Description)new DescriptionInt(0) })
         .OrderBy(o => o.CurrentLang)
         .ToList();
    }
  }

  #endregion Methods
}