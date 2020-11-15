namespace AnnoSavegameViewer {
  using AnnoSavegameViewer.Serialization;
  using AnnoSavegameViewer.Structures.Savegame.Generated;
  using AnnoSavegameViewer.Templates;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  public static class SaveGameReader {
		public async static Task ReadFileAsync(string path) {
			await Task.Run(async () => {
				if (System.IO.File.Exists(path)) {
					var data = await AnnoFileSerializer.ReadFileAsync<DataBaseNode>(path);
					//var reader = new MemoryReader((Memory<byte>)await System.IO.File.ReadAllBytesAsync(path));
					//var a7s = new A7SFormat(ref reader);
					//var data = FileDBSerializer.Convert<DataBaseNode>(a7s.A7SData);
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
}
