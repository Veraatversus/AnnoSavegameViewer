using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class NeededPublicValue {

[BinaryContent(Name = "PublicGUID", NodeType = BinaryContentTypes.Attribute)]
public HexString PublicGUID { get; set; }

[BinaryContent(Name = "Covered", NodeType = BinaryContentTypes.Attribute)]
public HexString Covered { get; set; }

[BinaryContent(Name = "Required", NodeType = BinaryContentTypes.Attribute)]
public HexString Required { get; set; }

}
}
