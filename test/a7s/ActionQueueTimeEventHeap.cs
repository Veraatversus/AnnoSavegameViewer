using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ActionQueueTimeEventHeap {

[BinaryContent(Name = "lastElement", NodeType = BinaryContentTypes.Attribute)]
public HexString LastElement { get; set; }

[BinaryContent(Name = "data", NodeType = BinaryContentTypes.Node)]
public ActionQueueTimeEventHeapData Data { get; set; }

}
}
