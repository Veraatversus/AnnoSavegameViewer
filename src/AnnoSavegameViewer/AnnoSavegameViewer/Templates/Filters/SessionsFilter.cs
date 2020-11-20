// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSavegameViewer.Templates.Filters {
  using AnnoSerializer.Comparer;
  using AnnoSerializer.Structures.DataTypes;
  using System;
  using System.Collections.Generic;
  using System.Linq;

  public class SessionsFilter : BaseFilter<Description> {

    #region Properties

    public override Func<IEnumerable<AnnoItem>, IEnumerable<AnnoItem>> FilterFunc => result => {
      return SelectedValue != null && SelectedValue.GUID != 0
        ? result.Where(w => w.Session.SessionDesc.SessionGUID.Equals(SelectedValue))
        : null;
    };

    public override int DescriptionID => -100011;

    #endregion Properties

    #region Constructors

    public SessionsFilter(ItemsHolder itemsHolder) : base(itemsHolder) => FilterType = FilterType.Selection;

    #endregion Constructors

    #region Methods

    public override void SetCurrenValues() {
      CurrentValues = ItemsHolder
         .GetResultWithoutFilter(this)
         .Where(s => s.Session != null)
         .Select(s => s.Session.SessionDesc.SessionGUID)
         .Distinct(DescriptionComparer.Default)
         .Concat(new[] { (Description)new DescriptionInt(0) })
         .OrderBy(o => o.CurrentLang)
         .ToList();
    }
  }

  #endregion Methods
}