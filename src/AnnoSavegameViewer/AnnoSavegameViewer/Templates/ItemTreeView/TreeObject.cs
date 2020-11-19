// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSavegameViewer.Templates {

  using System;
  using AnnoSerializer.Structures.DataTypes;

  public class TreeObject : TreeBase<TreeItem> {

    #region Public Properties

    public override Func<AnnoItem, Description> DescriptionSelector => item => item.GUID;

    #endregion Public Properties
  }
}