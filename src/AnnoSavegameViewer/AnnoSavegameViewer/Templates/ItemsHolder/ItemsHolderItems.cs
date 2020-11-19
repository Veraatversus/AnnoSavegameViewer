﻿// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSavegameViewer.Templates {
  using AnnoSavegameViewer.Templates.Filters;

  public class ItemsHolderItems : ItemsHolder {

    #region Public Constructors

    public ItemsHolderItems() : base(() => ProgrammSettings.CurrentSavegame?.GameObjects?.Items) {
      StandardFilters.Add("Player", new PlayerFilter(this));
      StandardFilters.Add("Session", new SessionsFilter(this));
      StandardFilters.Add("Area", new AreasFilter(this));
      StandardFilters.Add("Text", new SearchTextFilter(this));
    }

    #endregion Public Constructors
  }
}