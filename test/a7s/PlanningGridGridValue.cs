using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class PlanningGridGridValue {

[BinaryContent(Name = "RandomFreeTile", NodeType = BinaryContentTypes.Attribute)]
public HexString RandomFreeTile { get; set; }

[BinaryContent(Name = "HarborOwner", NodeType = BinaryContentTypes.Attribute)]
public HexString HarborOwner { get; set; }

[BinaryContent(Name = "UnblockedCells", NodeType = BinaryContentTypes.Attribute)]
public HexString UnblockedCells { get; set; }

[BinaryContent(Name = "EdgeReachabilities", NodeType = BinaryContentTypes.Attribute)]
public HexString EdgeReachabilities { get; set; }

[BinaryContent(Name = "State", NodeType = BinaryContentTypes.Attribute)]
public HexString State { get; set; }

}
}
