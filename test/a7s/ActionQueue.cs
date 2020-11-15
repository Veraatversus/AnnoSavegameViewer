using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ActionQueue {

[BinaryContent(Name = "TimeEventHeap", NodeType = BinaryContentTypes.Node)]
public TimeEventHeap TimeEventHeap { get; set; }

[BinaryContent(Name = "IDManager", NodeType = BinaryContentTypes.Node)]
public ActionQueueIDManager IDManager { get; set; }

}
}
