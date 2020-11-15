using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class MineProhibitZonesValue {

[BinaryContent(Name = "center", NodeType = BinaryContentTypes.Attribute)]
public HexString Center { get; set; }

[BinaryContent(Name = "radius", NodeType = BinaryContentTypes.Attribute)]
public HexString Radius { get; set; }

[BinaryContent(Name = "area", NodeType = BinaryContentTypes.Attribute)]
public HexString Area { get; set; }

}
}
