using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class TimeEventHeap {

[BinaryContent(Name = "lastElement", NodeType = BinaryContentTypes.Attribute)]
public HexString LastElement { get; set; }

[BinaryContent(Name = "data", NodeType = BinaryContentTypes.Node)]
public TimeEventHeapData Data { get; set; }

}
}
