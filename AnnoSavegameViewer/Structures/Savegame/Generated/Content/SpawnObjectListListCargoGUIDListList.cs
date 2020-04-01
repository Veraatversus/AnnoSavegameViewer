using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SpawnObjectListListCargoGUIDListList {

    [BinaryContent(Name = "CargoGUID", NodeType = BinaryContentTypes.Attribute)]
    public object CargoGUID { get; set; }

    [BinaryContent(Name = "CargoAmount", NodeType = BinaryContentTypes.Attribute)]
    public object CargoAmount { get; set; }

  }
}