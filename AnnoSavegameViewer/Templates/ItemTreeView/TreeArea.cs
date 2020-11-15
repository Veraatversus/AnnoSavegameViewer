namespace AnnoSavegameViewer.Templates {
  using AnnoSerializer.Structures.DataTypes;
  using System;

  public class TreeArea : TreeBase<TreeObject> {

    #region Public Properties

    public override Func<AnnoItem, Description> DescriptionSelector => item => item.ParentObject?.Guid ?? new DescriptionInt(100375);

    #endregion Public Properties
  }
}