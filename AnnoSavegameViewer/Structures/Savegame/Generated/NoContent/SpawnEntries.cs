using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SpawnEntries {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public SpawnEntriesList SpawnEntriesList { get; set; }

  }
}