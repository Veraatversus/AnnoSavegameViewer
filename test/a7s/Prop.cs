using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class Prop {

[BinaryContent(Name = "Position", NodeType = BinaryContentTypes.Attribute)]
public HexString Position { get; set; }

[BinaryContent(Name = "Rotation", NodeType = BinaryContentTypes.Attribute)]
public HexString Rotation { get; set; }

[BinaryContent(Name = "Scale", NodeType = BinaryContentTypes.Attribute)]
public HexString Scale { get; set; }

[BinaryContent(Name = "Color", NodeType = BinaryContentTypes.Attribute)]
public HexString Color { get; set; }

}
}
