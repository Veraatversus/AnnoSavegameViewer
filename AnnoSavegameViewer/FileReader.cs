using AnnoSavegameViewer.Serialization.FileDBSerializer;
using AnnoSavegameViewer.Serialization.Memory;
using AnnoSavegameViewer.Structures.A7S;
using AnnoSavegameViewer.Structures.Savegame.Generated;
using AnnoSavegameViewer.Templates;
using System;
using System.Threading.Tasks;

namespace AnnoSavegameViewer {

  public static class FileReader {

    #region Public Methods

    public async static Task ReadFileAsync(string path) {
      await Task.Run(async () => {
        if (System.IO.File.Exists(path)) {
          var reader = new MemoryReader((Memory<byte>)await System.IO.File.ReadAllBytesAsync(path));
          var a7s = new A7S(ref reader);
          var data = await FileDBSerializer.ConvertAsync<DataBaseNode>(a7s.A7SData);
          var gameObjects = new AnnoGameObjects(data);
          ProgrammSettings.CurrentSavegame = new Savegame {
            FilePath = path,
            Data = data,
            GameObjects = gameObjects
          };
          //var lookup = g.Items.ToLookup(i => i.Participant.GUID, new DescriptionComparer());
          //var player = lookup.FirstOrDefault(i => i.Key.GUID == 41);
          //var z = TreeWorld.Create(player.Key, player);
        }
      }).ConfigureAwait(true);
    }
  }

  #endregion Public Methods
}