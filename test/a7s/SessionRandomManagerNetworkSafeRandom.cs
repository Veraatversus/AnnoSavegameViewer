using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class SessionRandomManagerNetworkSafeRandom {

[BinaryContent(Name = "P1", NodeType = BinaryContentTypes.Attribute)]
public HexString P1 { get; set; }

[BinaryContent(Name = "P2", NodeType = BinaryContentTypes.Attribute)]
public HexString P2 { get; set; }

[BinaryContent(Name = "Buffer", NodeType = BinaryContentTypes.Attribute)]
public HexString Buffer { get; set; }

[BinaryContent(Name = "Counter", NodeType = BinaryContentTypes.Attribute)]
public HexString Counter { get; set; }

}
}
