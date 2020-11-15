namespace AnnoSavegameViewer.Templates.Filters {
  using AnnoSerializer.Comparer;
  using AnnoSerializer.Structures.DataTypes;
  using System;
  using System.Collections.Generic;
  using System.Linq;

  public class PlayerFilter : BaseFilter<Description> {

    #region Properties

    public override Func<IEnumerable<AnnoItem>, IEnumerable<AnnoItem>> FilterFunc => result => SelectedValue?.GUID != 0 ? result.Where(w => w.Participant.GUID.Equals(SelectedValue)) : null;

    public override int DescriptionID => -100010;

    #endregion Properties

    #region Constructors

    public PlayerFilter(ItemsHolder itemsHolder) : base(itemsHolder) => FilterType = FilterType.Selection;

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