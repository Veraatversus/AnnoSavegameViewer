namespace AnnoSavegameViewer.Templates {
  using AnnoSavegameViewer.Structures.DataTypes;
  using System;

  public class TreeArea : TreeBase<TreeObject> {

    #region Public Properties

    public override Func<AnnoItem, Description> DescriptionSelector => item => item.ParentObject?.Guid ?? new DescriptionInt(100375);

    #endregion Public Properties
  }
}