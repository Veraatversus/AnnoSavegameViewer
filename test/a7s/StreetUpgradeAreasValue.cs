using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class StreetUpgradeAreasValue {

[BinaryContent(Name = "Center", NodeType = BinaryContentTypes.Attribute)]
public HexString Center { get; set; }

[BinaryContent(Name = "CurrentSideLength", NodeType = BinaryContentTypes.Attribute)]
public HexString CurrentSideLength { get; set; }

[BinaryContent(Name = "SideLengthMax", NodeType = BinaryContentTypes.Attribute)]
public HexString SideLengthMax { get; set; }

}
}
