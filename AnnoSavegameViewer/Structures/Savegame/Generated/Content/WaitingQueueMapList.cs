using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class WaitingQueueMapList {

    [BinaryContent(Name = "EllipsisDimensions", NodeType = BinaryContentTypes.Attribute)]
    public object EllipsisDimensions { get; set; }

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public WaitingQueueMapListValue Value { get; set; }

    [BinaryContent(Name = "Layer", NodeType = BinaryContentTypes.Node)]
    public Layer Layer { get; set; }

    [BinaryContent(Name = "QueueEntryList", NodeType = BinaryContentTypes.Node)]
    public QueueEntryList QueueEntryList { get; set; }

    [BinaryContent(Name = "WaitingRowArray", NodeType = BinaryContentTypes.Node)]
    public WaitingRowArray WaitingRowArray { get; set; }

  }
}