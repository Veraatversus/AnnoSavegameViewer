using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class NextWaypointPath {

[BinaryContent(Name = "Path", NodeType = BinaryContentTypes.Attribute)]
public HexString Path { get; set; }

[BinaryContent(Name = "AverageSpeed", NodeType = BinaryContentTypes.Attribute)]
public HexString AverageSpeed { get; set; }

}
}
