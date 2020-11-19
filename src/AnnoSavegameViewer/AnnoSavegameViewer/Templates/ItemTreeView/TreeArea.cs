// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSavegameViewer.Templates {

  using System;
  using AnnoSerializer.Structures.DataTypes;

  public class TreeArea : TreeBase<TreeObject> {

    #region Public Properties

    public override Func<AnnoItem, Description> DescriptionSelector => item => item.ParentObject?.Guid ?? new DescriptionInt(100375);

    #endregion Public Properties
  }
}