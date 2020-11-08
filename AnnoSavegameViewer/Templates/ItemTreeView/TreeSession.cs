using AnnoSavegameViewer.Structures.Savegame;
using System;

namespace AnnoSavegameViewer.Templates {

  public class TreeSession : TreeBase<TreeArea> {

    #region Public Properties

    public override Func<AnnoItem, Description> DescriptionSelector {
      get {
        return item => {
          return item?.AreaInfo?.CityNameOrGuid != null ? new Description(item.AreaInfo.CityNameOrGuid) : new DescriptionInt(2342);
        };
      }
    }

    #endregion Public Properties
  }
}