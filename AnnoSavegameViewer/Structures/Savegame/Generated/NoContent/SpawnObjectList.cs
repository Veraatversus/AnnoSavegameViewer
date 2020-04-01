using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SpawnObjectList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<SpawnObjectListList> SpawnObjectListList { get; set; }

  }
}