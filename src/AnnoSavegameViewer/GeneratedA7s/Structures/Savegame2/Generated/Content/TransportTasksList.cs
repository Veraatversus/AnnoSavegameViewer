namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class TransportTasksList {

    [BinaryContent(Name = "From", NodeType = BinaryContentTypes.Attribute)]
    public object From { get; set; }

    [BinaryContent(Name = "To", NodeType = BinaryContentTypes.Attribute)]
    public object To { get; set; }

    [BinaryContent(Name = "Product", NodeType = BinaryContentTypes.Attribute)]
    public object Product { get; set; }

    [BinaryContent(Name = "Balance", NodeType = BinaryContentTypes.Attribute)]
    public object Balance { get; set; }

    [BinaryContent(Name = "TransportType", NodeType = BinaryContentTypes.Node)]
    public TransportTasksListTransportType TransportType { get; set; }

  }
}