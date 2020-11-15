namespace AnnoSavegameViewer.Templates {
  using AnnoSavegameViewer.Structures.DataTypes;
  using System;

  public class TreeSession : TreeBase<TreeArea> {

    #region Public Properties

    public override Func<AnnoItem, Description> DescriptionSelector => item => item?.AreaInfo?.CityName != null ? new Description(item.AreaInfo.CityName) : new DescriptionInt(2342);

    #endregion Public Properties
  }
}