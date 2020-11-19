namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class OrdersList {

    [BinaryContent(Name = "Type", NodeType = BinaryContentTypes.Attribute)]
    public object Type { get; set; }

    [BinaryContent(Name = "ProductGUID", NodeType = BinaryContentTypes.Attribute)]
    public object ProductGUID { get; set; }

    [BinaryContent(Name = "ProductAmount", NodeType = BinaryContentTypes.Attribute)]
    public object ProductAmount { get; set; }

  }
}