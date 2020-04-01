using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SpawnEntries {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<SpawnEntriesList> SpawnEntriesList { get; set; }

  }
}