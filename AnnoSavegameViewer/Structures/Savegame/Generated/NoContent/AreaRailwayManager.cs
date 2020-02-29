using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaRailwayManager {

    [BinaryContent(Name = "RailwayNodeGraph", NodeType = BinaryContentTypes.Node)]
    public RailwayNodeGraph RailwayNodeGraph { get; set; }

  }
}