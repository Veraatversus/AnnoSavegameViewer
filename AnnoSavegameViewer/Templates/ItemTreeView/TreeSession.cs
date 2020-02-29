using AnnoSavegameViewer.Structures.Savegame;
using System;

namespace AnnoSavegameViewer.Templates {

  public class TreeSession : TreeBase<TreeArea> {

    #region Public Properties

    public override Func<AnnoItem, Description> DescriptionSelector {
      get {
        return item => {
          return item?.AreaInfo?.CityName != null ? new Description(item.AreaInfo.CityName) : new DescriptionInt(2342);
        };
      }
    }

    #endregion Public Properties
  }
}