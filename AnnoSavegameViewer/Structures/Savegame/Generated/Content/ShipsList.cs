namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class ShipsList {

    [BinaryContent(Name = "Timestamp", NodeType = BinaryContentTypes.Attribute)]
    public object Timestamp { get; set; }

    [BinaryContent(Name = "UsingSession", NodeType = BinaryContentTypes.Attribute)]
    public object UsingSession { get; set; }

    [BinaryContent(Name = "Ship", NodeType = BinaryContentTypes.Attribute)]
    public object Ship { get; set; }

    [BinaryContent(Name = "ShipGUID", NodeType = BinaryContentTypes.Attribute)]
    public object ShipGUID { get; set; }

    [BinaryContent(Name = "Purpose", NodeType = BinaryContentTypes.Node)]
    public Purpose Purpose { get; set; }

  }
}