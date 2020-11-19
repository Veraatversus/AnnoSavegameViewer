// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSavegameViewer.Templates {

  using AnnoSerializer.Structures.Generated.a7s;

  public class SavegameHolder {

    #region Public Properties

    public string FilePath { get; set; }
    public A7s_File Data { get; set; }
    public AnnoGameObjects GameObjects { get; set; }

    #endregion Public Properties
  }
}