namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class SpawnEntries {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<SpawnEntriesList> SpawnEntriesList { get; set; }

  }
}