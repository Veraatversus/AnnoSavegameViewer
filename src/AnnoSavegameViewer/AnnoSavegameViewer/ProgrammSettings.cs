// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSavegameViewer {

  using System;
  using System.ComponentModel;
  using System.Runtime.CompilerServices;
  using AnnoSavegameViewer.Templates;

  public static class ProgrammSettings {

    #region Public Properties

    public static SavegameHolder CurrentSavegame {
      get => currentSavegame;
      set {
        if (currentSavegame != value) {
          currentSavegame = value;
          NotifyStaticPropertyChanged();
        }
      }
    }

    public static MainWindow MainWindow { get; set; }

    #endregion Public Properties

    #region Public Events

    public static event EventHandler<PropertyChangedEventArgs> StaticPropertyChanged;

    #endregion Public Events

    #region Private Methods

    private static void NotifyStaticPropertyChanged([CallerMemberName] string propertyName = null) => StaticPropertyChanged?.Invoke(null, new PropertyChangedEventArgs(propertyName));

    #endregion Private Methods

    #region Private Fields

    private static SavegameHolder currentSavegame;

    #endregion Private Fields
  }
}