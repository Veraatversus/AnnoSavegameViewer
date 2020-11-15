using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ShareValueFluctuation {

[BinaryContent(Name = "NextChange", NodeType = BinaryContentTypes.Attribute)]
public HexString NextChange { get; set; }

[BinaryContent(Name = "Velocity", NodeType = BinaryContentTypes.Attribute)]
public HexString Velocity { get; set; }

[BinaryContent(Name = "Offset", NodeType = BinaryContentTypes.Attribute)]
public HexString Offset { get; set; }

[BinaryContent(Name = "Fluctuating", NodeType = BinaryContentTypes.Attribute)]
public HexString Fluctuating { get; set; }

}
}
