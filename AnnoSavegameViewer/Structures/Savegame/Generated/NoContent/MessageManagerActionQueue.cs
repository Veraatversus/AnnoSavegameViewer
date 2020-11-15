namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class MessageManagerActionQueue {

    [BinaryContent(Name = "TimeEventHeap", NodeType = BinaryContentTypes.Node)]
    public MessageManagerActionQueueTimeEventHeap TimeEventHeap { get; set; }

    [BinaryContent(Name = "IDManager", NodeType = BinaryContentTypes.Node)]
    public MessageManagerActionQueueIDManager IDManager { get; set; }

  }
}