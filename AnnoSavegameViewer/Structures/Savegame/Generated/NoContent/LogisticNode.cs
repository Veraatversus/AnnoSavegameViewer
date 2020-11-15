namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class LogisticNode {

    [BinaryContent(Name = "Storage", NodeType = BinaryContentTypes.Node)]
    public LogisticNodeStorage Storage { get; set; }

    [BinaryContent(Name = "Transporters", NodeType = BinaryContentTypes.Node)]
    public LogisticNodeTransporters Transporters { get; set; }

    [BinaryContent(Name = "TransporterQueue", NodeType = BinaryContentTypes.Node)]
    public TransporterQueue TransporterQueue { get; set; }

  }
}