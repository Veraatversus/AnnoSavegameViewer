using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class MessageManagerActionQueue {

[BinaryContent(Name = "TimeEventHeap", NodeType = BinaryContentTypes.Node)]
public ActionQueueTimeEventHeap TimeEventHeap { get; set; }

[BinaryContent(Name = "IDManager", NodeType = BinaryContentTypes.Node)]
public MessageManagerActionQueueIDManager IDManager { get; set; }

}
}
