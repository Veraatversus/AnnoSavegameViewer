// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSavegameViewer.Templates {

  using System;
  using AnnoSerializer.Structures.DataTypes;

  public class TreeSession : TreeBase<TreeArea> {

    #region Public Properties

    public override Func<AnnoItem, Description> DescriptionSelector => item => item?.AreaInfo?.CityDescription ?? new DescriptionInt(2342);

    #endregion Public Properties
  }
}