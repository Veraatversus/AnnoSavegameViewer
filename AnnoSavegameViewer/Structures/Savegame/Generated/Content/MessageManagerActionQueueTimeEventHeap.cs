using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MessageManagerActionQueueTimeEventHeap {

    [BinaryContent(Name = "lastElement", NodeType = BinaryContentTypes.Attribute)]
    public object LastElement { get; set; }

    [BinaryContent(Name = "data", NodeType = BinaryContentTypes.Node)]
    public List<MessageManagerActionQueueTimeEventHeapData> Data { get; set; }

  }
}