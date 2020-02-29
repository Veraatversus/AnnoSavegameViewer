using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MessageManagerActionQueueTimeEventHeapDataElement {

    [BinaryContent(Name = "Data", NodeType = BinaryContentTypes.Attribute)]
    public object Data { get; set; }

    [BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
    public object ID { get; set; }

    [BinaryContent(Name = "Time", NodeType = BinaryContentTypes.Attribute)]
    public object Time { get; set; }

  }
}