namespace AnnoSavegameViewer.Templates {
  using AnnoSerializer.Structures.DataTypes;
  using System;

  public class TreeObject : TreeBase<TreeItem> {

    #region Public Properties

    public override Func<AnnoItem, Description> DescriptionSelector => item => item.GUID;

    #endregion Public Properties
  }
}