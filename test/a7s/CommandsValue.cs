using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class CommandsValue {

[BinaryContent(Name = "SessionID", NodeType = BinaryContentTypes.Attribute)]
public HexString SessionID { get; set; }

[BinaryContent(Name = "NextTickTime", NodeType = BinaryContentTypes.Attribute)]
public HexString NextTickTime { get; set; }

[BinaryContent(Name = "Parent", NodeType = BinaryContentTypes.Node)]
public NoneParent Parent { get; set; }

[BinaryContent(Name = "CommandGroupInformation", NodeType = BinaryContentTypes.Node)]
public CommandGroupInformation CommandGroupInformation { get; set; }

[BinaryContent(Name = "StopRadius", NodeType = BinaryContentTypes.Attribute)]
public HexString StopRadius { get; set; }

[BinaryContent(Name = "TargetDir", NodeType = BinaryContentTypes.Attribute)]
public HexString TargetDir { get; set; }

[BinaryContent(Name = "AddLaneOffset", NodeType = BinaryContentTypes.Attribute)]
public HexString AddLaneOffset { get; set; }

[BinaryContent(Name = "TargetObjectID", NodeType = BinaryContentTypes.Attribute)]
public HexString TargetObjectID { get; set; }

[BinaryContent(Name = "MainState", NodeType = BinaryContentTypes.Attribute)]
public HexString MainState { get; set; }

[BinaryContent(Name = "WayPositions", NodeType = BinaryContentTypes.Attribute)]
public HexString WayPositions { get; set; }

[BinaryContent(Name = "DriftingInstruction", NodeType = BinaryContentTypes.Node)]
public DriftingInstruction DriftingInstruction { get; set; }

[BinaryContent(Name = "CurrentTargetIndex", NodeType = BinaryContentTypes.Attribute)]
public HexString CurrentTargetIndex { get; set; }

[BinaryContent(Name = "DangerLayerID", NodeType = BinaryContentTypes.Attribute)]
public HexString DangerLayerID { get; set; }

[BinaryContent(Name = "CommandType", NodeType = BinaryContentTypes.Attribute)]
public HexString CommandType { get; set; }

[BinaryContent(Name = "TargetSession", NodeType = BinaryContentTypes.Attribute)]
public HexString TargetSession { get; set; }

[BinaryContent(Name = "TargetPosition", NodeType = BinaryContentTypes.Attribute)]
public HexString TargetPosition { get; set; }

[BinaryContent(Name = "TargetDirection", NodeType = BinaryContentTypes.Attribute)]
public HexString TargetDirection { get; set; }

[BinaryContent(Name = "StillWaitingForGroup", NodeType = BinaryContentTypes.Attribute)]
public HexString StillWaitingForGroup { get; set; }

[BinaryContent(Name = "NoLogicOutOfPlayable", NodeType = BinaryContentTypes.Attribute)]
public HexString NoLogicOutOfPlayable { get; set; }

}
}
