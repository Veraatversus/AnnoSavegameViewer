using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ProblemDetector {

[BinaryContent(Name = "CountsPerGUID", NodeType = BinaryContentTypes.Node)]
public CountsPerGUID CountsPerGUID { get; set; }

[BinaryContent(Name = "LastTradeShipCount", NodeType = BinaryContentTypes.Attribute)]
public HexString LastTradeShipCount { get; set; }

[BinaryContent(Name = "LastShipProgress", NodeType = BinaryContentTypes.Attribute)]
public HexString LastShipProgress { get; set; }

[BinaryContent(Name = "LastBuildingProgress", NodeType = BinaryContentTypes.Attribute)]
public HexString LastBuildingProgress { get; set; }

[BinaryContent(Name = "LastCheck", NodeType = BinaryContentTypes.Attribute)]
public HexString LastCheck { get; set; }

[BinaryContent(Name = "LastCleanupTick", NodeType = BinaryContentTypes.Attribute)]
public HexString LastCleanupTick { get; set; }

[BinaryContent(Name = "LastForceRemove", NodeType = BinaryContentTypes.Attribute)]
public HexString LastForceRemove { get; set; }

[BinaryContent(Name = "ShipSolveCount", NodeType = BinaryContentTypes.Attribute)]
public HexString ShipSolveCount { get; set; }

[BinaryContent(Name = "BuildingSolves", NodeType = BinaryContentTypes.Node)]
public BuildingSolves BuildingSolves { get; set; }

[BinaryContent(Name = "ForceReconstruct", NodeType = BinaryContentTypes.Attribute)]
public HexString ForceReconstruct { get; set; }

}
}
