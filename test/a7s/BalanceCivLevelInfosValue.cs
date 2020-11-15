using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class BalanceCivLevelInfosValue {

[BinaryContent(Name = "PersonCount", NodeType = BinaryContentTypes.Attribute)]
public HexString PersonCount { get; set; }

[BinaryContent(Name = "DefaultBuildingCount", NodeType = BinaryContentTypes.Attribute)]
public HexString DefaultBuildingCount { get; set; }

[BinaryContent(Name = "WorkforceAvailable", NodeType = BinaryContentTypes.Attribute)]
public HexString WorkforceAvailable { get; set; }

[BinaryContent(Name = "WorkforceConsumed", NodeType = BinaryContentTypes.Attribute)]
public HexString WorkforceConsumed { get; set; }

}
}
