using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Shipyard {

    [BinaryContent(Name = "RallyPoint", NodeType = BinaryContentTypes.Attribute)]
    public object RallyPoint { get; set; }

    [BinaryContent(Name = "ConstructionQueue", NodeType = BinaryContentTypes.Node)]
    public ShipyardConstructionQueue ConstructionQueue { get; set; }

  }
}