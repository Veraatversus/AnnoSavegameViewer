using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CargoGUIDList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public CargoGUIDListList CargoGUIDListList { get; set; }

  }
}