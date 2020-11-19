// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSavegameViewer {

  using System.Threading.Tasks;
  using AnnoSavegameViewer.Templates;
  using AnnoSerializer.Serialization;
  using AnnoSerializer.Structures.Generated.a7s;

  public static class SaveGameReader {

    #region Public Methods

    public async static Task ReadFileAsync(string path) {
      await Task.Run(async () => {
        if (System.IO.File.Exists(path)) {
          var data = await AnnoFileSerializer.ReadFileAsync<A7s_File>(path);
          var gameObjects = new AnnoGameObjects(data);
          ProgrammSettings.CurrentSavegame = new SavegameHolder {
            FilePath = path,
            Data = data,
            GameObjects = gameObjects
          };
        }
      }).ConfigureAwait(true);
    }

    #endregion Public Methods
  }
}