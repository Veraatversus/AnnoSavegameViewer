using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ShipHandler {

[BinaryContent(Name = "Ships", NodeType = BinaryContentTypes.Node)]
public Ships Ships { get; set; }

[BinaryContent(Name = "Requests", NodeType = BinaryContentTypes.Node)]
public Requests Requests { get; set; }

[BinaryContent(Name = "CraftableWhitelist", NodeType = BinaryContentTypes.Node)]
public CraftableWhitelist CraftableWhitelist { get; set; }

[BinaryContent(Name = "Construction", NodeType = BinaryContentTypes.Node)]
public Construction Construction { get; set; }

[BinaryContent(Name = "LastDestroyShipTick", NodeType = BinaryContentTypes.Attribute)]
public HexString LastDestroyShipTick { get; set; }

[BinaryContent(Name = "DestructionNot", NodeType = BinaryContentTypes.Node)]
public DestructionNot DestructionNot { get; set; }

[BinaryContent(Name = "LastKilled", NodeType = BinaryContentTypes.Node)]
public LastKilled LastKilled { get; set; }

[BinaryContent(Name = "TargetShipWeights", NodeType = BinaryContentTypes.Node)]
public TargetShipWeights TargetShipWeights { get; set; }

[BinaryContent(Name = "MetaRequestID", NodeType = BinaryContentTypes.Attribute)]
public HexString MetaRequestID { get; set; }

[BinaryContent(Name = "DestroyedIdleShips", NodeType = BinaryContentTypes.Attribute)]
public HexString DestroyedIdleShips { get; set; }

}
}
