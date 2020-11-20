namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class ProcessingTransportersList {

    [BinaryContent(Name = "ProcessingTime", NodeType = BinaryContentTypes.Attribute)]
    public object ProcessingTime { get; set; }

    [BinaryContent(Name = "ProcessingEndTime", NodeType = BinaryContentTypes.Attribute)]
    public object ProcessingEndTime { get; set; }

    [BinaryContent(Name = "Transporter", NodeType = BinaryContentTypes.Node)]
    public ProcessingTransportersListTransporter Transporter { get; set; }

  }
}