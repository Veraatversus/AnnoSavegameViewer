using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class SettleLocation {

[BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
public HexString AreaID { get; set; }

[BinaryContent(Name = "Stopover", NodeType = BinaryContentTypes.Attribute)]
public HexString Stopover { get; set; }

[BinaryContent(Name = "ApproachType", NodeType = BinaryContentTypes.Node)]
public ApproachType ApproachType { get; set; }

[BinaryContent(Name = "Coastline", NodeType = BinaryContentTypes.Node)]
public Coastline Coastline { get; set; }

[BinaryContent(Name = "KontorPos", NodeType = BinaryContentTypes.Attribute)]
public HexString KontorPos { get; set; }

[BinaryContent(Name = "RecommendedPos", NodeType = BinaryContentTypes.Node)]
public RecommendedPos RecommendedPos { get; set; }

}
}
