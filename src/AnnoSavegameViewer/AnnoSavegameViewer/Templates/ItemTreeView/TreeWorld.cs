// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSavegameViewer.Templates {

  using System;
  using System.Collections.Generic;
  using AnnoSerializer.Structures.DataTypes;

  public class TreeWorld : TreeBase<TreeSession> {

    #region Public Properties

    public override Func<AnnoItem, Description> DescriptionSelector => item => item.Session.SessionDesc.SessionGUID;

    #endregion Public Properties

    #region Public Methods

    public static TreeWorld Create(Description description, IEnumerable<AnnoItem> items) {
      var world = new TreeWorld { Description = description };
      if (items != null) {
        foreach (var item in items) {
          world.Add(item);
        }
      }
      return world;
    }

    #endregion Public Methods

  }
}