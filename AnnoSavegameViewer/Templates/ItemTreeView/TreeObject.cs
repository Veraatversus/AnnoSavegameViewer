namespace AnnoSavegameViewer.Templates {
  using AnnoSavegameViewer.Structures.DataTypes;
  using System;

  public class TreeObject : TreeBase<TreeItem> {

    #region Public Properties

    public override Func<AnnoItem, Description> DescriptionSelector => item => item.GUID;

    #endregion Public Properties
  }
}