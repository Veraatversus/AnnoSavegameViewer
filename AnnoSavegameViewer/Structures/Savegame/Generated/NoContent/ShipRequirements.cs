using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ShipRequirements {

    [BinaryContent(Name = "TransportationType", NodeType = BinaryContentTypes.Node)]
    public TransportationType TransportationType { get; set; }

  }
}