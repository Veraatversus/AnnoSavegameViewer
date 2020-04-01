using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaRailwayManager {

    [BinaryContent(Name = "RailwayNodeGraph", NodeType = BinaryContentTypes.Node)]
    public RailwayNodeGraph RailwayNodeGraph { get; set; }

  }
}