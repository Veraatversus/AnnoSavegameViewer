namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class TransporterQueue {

    [BinaryContent(Name = "QueuedTransporters", NodeType = BinaryContentTypes.Node)]
    public QueuedTransporters QueuedTransporters { get; set; }

    [BinaryContent(Name = "ProcessingTransporters", NodeType = BinaryContentTypes.Node)]
    public ProcessingTransporters ProcessingTransporters { get; set; }

  }
}