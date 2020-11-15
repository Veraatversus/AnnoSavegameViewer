using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class QueuedTransfersValue {

[BinaryContent(Name = "TransferID", NodeType = BinaryContentTypes.Attribute)]
public HexString TransferID { get; set; }

[BinaryContent(Name = "SourceSessionGUID", NodeType = BinaryContentTypes.Attribute)]
public HexString SourceSessionGUID { get; set; }

[BinaryContent(Name = "TargetSessionGUID", NodeType = BinaryContentTypes.Attribute)]
public HexString TargetSessionGUID { get; set; }

[BinaryContent(Name = "TargetGameObject", NodeType = BinaryContentTypes.Attribute)]
public HexString TargetGameObject { get; set; }

[BinaryContent(Name = "TravelTimeLeft", NodeType = BinaryContentTypes.Attribute)]
public HexString TravelTimeLeft { get; set; }

[BinaryContent(Name = "TotalTravelTime", NodeType = BinaryContentTypes.Attribute)]
public HexString TotalTravelTime { get; set; }

[BinaryContent(Name = "TargetPosition", NodeType = BinaryContentTypes.Attribute)]
public HexString TargetPosition { get; set; }

[BinaryContent(Name = "TargetDirection", NodeType = BinaryContentTypes.Attribute)]
public HexString TargetDirection { get; set; }

[BinaryContent(Name = "State", NodeType = BinaryContentTypes.Node)]
public State State { get; set; }

}
}
