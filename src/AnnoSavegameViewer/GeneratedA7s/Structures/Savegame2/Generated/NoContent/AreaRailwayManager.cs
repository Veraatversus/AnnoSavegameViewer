namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class AreaRailwayManager {

    [BinaryContent(Name = "RailwayNodeGraph", NodeType = BinaryContentTypes.Node)]
    public RailwayNodeGraph RailwayNodeGraph { get; set; }

  }
}