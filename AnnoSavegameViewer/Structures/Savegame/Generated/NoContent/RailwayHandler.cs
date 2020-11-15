namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class RailwayHandler {

    [BinaryContent(Name = "RailwayBuildings", NodeType = BinaryContentTypes.Node)]
    public RailwayBuildings RailwayBuildings { get; set; }

  }
}