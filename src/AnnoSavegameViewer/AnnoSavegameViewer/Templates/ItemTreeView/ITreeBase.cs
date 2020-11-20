// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSavegameViewer.Templates {
  using AnnoSerializer.Structures.DataTypes;
  using System;

  public interface ITreeBase {

    #region Public Properties

    int CountUnused { get; set; }
    int CountUsed { get; set; }
    Description Description { get; set; }
    Func<AnnoItem, Description> DescriptionSelector { get; }

    #endregion Public Properties

    #region Public Methods

    void Add(AnnoItem annoItem);

    #endregion Public Methods
  }
}