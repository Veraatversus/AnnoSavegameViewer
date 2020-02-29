using AnnoSavegameViewer.Structures.Savegame;
using System;

namespace AnnoSavegameViewer.Templates {

  public class TreeObject : TreeBase<TreeItem> {

    #region Public Properties

    public override Func<AnnoItem, Description> DescriptionSelector => item => item.GUID;

    #endregion Public Properties
  }
}