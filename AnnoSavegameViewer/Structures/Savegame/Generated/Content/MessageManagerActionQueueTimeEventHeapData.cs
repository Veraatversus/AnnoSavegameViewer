using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MessageManagerActionQueueTimeEventHeapData {

    [BinaryContent(Name = "prio", NodeType = BinaryContentTypes.Attribute)]
    public object Prio { get; set; }

    [BinaryContent(Name = "element", NodeType = BinaryContentTypes.Node)]
    public MessageManagerActionQueueTimeEventHeapDataElement Element { get; set; }

  }
}