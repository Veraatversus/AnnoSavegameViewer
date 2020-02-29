using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class RailwayHandler {

    [BinaryContent(Name = "RailwayBuildings", NodeType = BinaryContentTypes.Node)]
    public RailwayBuildings RailwayBuildings { get; set; }

  }
}