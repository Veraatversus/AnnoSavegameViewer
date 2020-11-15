namespace AnnoSavegameViewer {
  using AnnoSerializer.Serialization;
  using AnnoSavegameViewer.Templates;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  using AnnoSerializer.Structures.Generated.a7s;

  public static class SaveGameReader {
		public async static Task ReadFileAsync(string path) {
			await Task.Run(async () => {
				if (System.IO.File.Exists(path)) {
					var data = await AnnoFileSerializer.ReadFileAsync<A7s_File>(path);
					var gameObjects = new AnnoGameObjects(data);
					ProgrammSettings.CurrentSavegame = new Savegame {
						FilePath = path,
						Data = data,
						GameObjects = gameObjects
					};
				}
			}).ConfigureAwait(true);
		}
	}
}
