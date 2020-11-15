using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class TimeEventHeapData {

[BinaryContent(Name = "prio", NodeType = BinaryContentTypes.Attribute)]
public HexString Prio { get; set; }

[BinaryContent(Name = "element", NodeType = BinaryContentTypes.Node)]
public Element Element { get; set; }

}
}
