﻿using AnnoSavegameViewer.Structures.Savegame;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AnnoSavegameViewer.Templates.Filters {

  public class AreasFilter : BaseFilter<Description> {

    #region Properties

    public override Func<IEnumerable<AnnoItem>, IEnumerable<AnnoItem>> FilterFunc => result => {
      if (SelectedValue != null && SelectedValue.GUID != 0) {
        return result.Where(w => w.AreaInfo?.CityNameOrGuid.Equals(SelectedValue.CurrentLang) == true);
      }
      return null;
    };

    public override int DescriptionID => -100012;

    #endregion Properties

    #region Constructors

    public AreasFilter(ItemsHolder itemsHolder) : base(itemsHolder) {
      FilterType = FilterType.Selection;
    }

    #endregion Constructors

    #region Methods

    public override void SetCurrenValues() {
      CurrentValues = ItemsHolder
         .GetResultWithoutFilter(this)
         .Where(s => s.AreaInfo != null)
         .Select(s => s.AreaInfo.CityNameOrGuid)
         .Distinct()
         .Select(s => new Description(s))
         .Concat(new[] { (Description)new DescriptionInt(0) })
         .OrderBy(o => o.CurrentLang)
         .ToList();
    }
  }

  #endregion Methods
}