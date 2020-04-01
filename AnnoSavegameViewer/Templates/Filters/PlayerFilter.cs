using AnnoSavegameViewer.Comparer;
using AnnoSavegameViewer.Structures.Savegame;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AnnoSavegameViewer.Templates.Filters {

  public class PlayerFilter : BaseFilter<Description> {

    #region Properties

    public override Func<IEnumerable<AnnoItem>, IEnumerable<AnnoItem>> FilterFunc => result => {
      if (SelectedValue != null && SelectedValue.GUID != 0) {
        return result.Where(w => w.Participant.GUID.Equals(SelectedValue));
      }
      return null;
    };

    public override int DescriptionID => -100010;

    #endregion Properties

    #region Constructors

    public PlayerFilter(ItemsHolder itemsHolder) : base(itemsHolder) {
      FilterType = FilterType.Selection;
    }

    #endregion Constructors

    #region Methods

    public override void SetCurrenValues() {
      CurrentValues = ItemsHolder
         .GetResultWithoutFilter(this)
         .Where(s => s.Participant != null)
         .Select(s => s.Participant.GUID)
         .Distinct(DescriptionComparer.Default)
         .Concat(new[] { (Description)new DescriptionInt(0) })
         .OrderBy(o => o.CurrentLang)
         .ToList();
    }
  }

  #endregion Methods
}