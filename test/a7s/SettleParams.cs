using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class SettleParams {

[BinaryContent(Name = "ForceArea", NodeType = BinaryContentTypes.Attribute)]
public HexString ForceArea { get; set; }

[BinaryContent(Name = "RecommendedPosition", NodeType = BinaryContentTypes.Node)]
public RecommendedPosition RecommendedPosition { get; set; }

[BinaryContent(Name = "SettleMissionType", NodeType = BinaryContentTypes.Node)]
public SettleMissionType SettleMissionType { get; set; }

}
}
