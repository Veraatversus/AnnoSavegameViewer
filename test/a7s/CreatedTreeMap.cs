using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class CreatedTreeMap {

[BinaryContent(Name = "x", NodeType = BinaryContentTypes.Attribute)]
public HexString X { get; set; }

[BinaryContent(Name = "y", NodeType = BinaryContentTypes.Attribute)]
public HexString Y { get; set; }

[BinaryContent(Name = "bits", NodeType = BinaryContentTypes.Attribute)]
public HexString Bits { get; set; }

}
}
