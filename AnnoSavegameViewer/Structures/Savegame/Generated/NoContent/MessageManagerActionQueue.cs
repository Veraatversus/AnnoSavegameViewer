using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MessageManagerActionQueue {

    [BinaryContent(Name = "TimeEventHeap", NodeType = BinaryContentTypes.Node)]
    public MessageManagerActionQueueTimeEventHeap TimeEventHeap { get; set; }

    [BinaryContent(Name = "IDManager", NodeType = BinaryContentTypes.Node)]
    public MessageManagerActionQueueIDManager IDManager { get; set; }

  }
}