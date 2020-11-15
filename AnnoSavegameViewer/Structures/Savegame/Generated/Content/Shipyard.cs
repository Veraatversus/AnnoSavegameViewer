namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class Shipyard {

    [BinaryContent(Name = "RallyPoint", NodeType = BinaryContentTypes.Attribute)]
    public object RallyPoint { get; set; }

    [BinaryContent(Name = "ConstructionQueue", NodeType = BinaryContentTypes.Node)]
    public ShipyardConstructionQueue ConstructionQueue { get; set; }

  }
}