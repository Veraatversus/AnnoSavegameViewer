using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class QueuedTransportersList {

    [BinaryContent(Name = "ProcessingTime", NodeType = BinaryContentTypes.Attribute)]
    public object ProcessingTime { get; set; }

    [BinaryContent(Name = "ProcessingEndTime", NodeType = BinaryContentTypes.Attribute)]
    public object ProcessingEndTime { get; set; }

    [BinaryContent(Name = "Transporter", NodeType = BinaryContentTypes.Node)]
    public Transporter Transporter { get; set; }

  }
}