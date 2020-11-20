namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class CommandsList {

    #region Public Properties

    [BinaryContent(Name = "NextTickTime", NodeType = BinaryContentTypes.Attribute)]
    public object NextTickTime { get; set; }

    [BinaryContent(Name = "StopRadius", NodeType = BinaryContentTypes.Attribute)]
    public object StopRadius { get; set; }

    [BinaryContent(Name = "TargetObjectID", NodeType = BinaryContentTypes.Attribute)]
    public object TargetObjectID { get; set; }

    [BinaryContent(Name = "MainState", NodeType = BinaryContentTypes.Attribute)]
    public object MainState { get; set; }

    [BinaryContent(Name = "WayPositions", NodeType = BinaryContentTypes.Attribute)]
    public object WayPositions { get; set; }

    [BinaryContent(Name = "CurrentTargetIndex", NodeType = BinaryContentTypes.Attribute)]
    public object CurrentTargetIndex { get; set; }

    [BinaryContent(Name = "DangerLayerID", NodeType = BinaryContentTypes.Attribute)]
    public object DangerLayerID { get; set; }

    [BinaryContent(Name = "AddLaneOffset", NodeType = BinaryContentTypes.Attribute)]
    public object AddLaneOffset { get; set; }

    [BinaryContent(Name = "NoLogicOutOfPlayable", NodeType = BinaryContentTypes.Attribute)]
    public object NoLogicOutOfPlayable { get; set; }

    [BinaryContent(Name = "CommandType", NodeType = BinaryContentTypes.Attribute)]
    public object CommandType { get; set; }

    [BinaryContent(Name = "TargetSession", NodeType = BinaryContentTypes.Attribute)]
    public object TargetSession { get; set; }

    [BinaryContent(Name = "TargetPosition", NodeType = BinaryContentTypes.Attribute)]
    public object TargetPosition { get; set; }

    [BinaryContent(Name = "TargetDirection", NodeType = BinaryContentTypes.Attribute)]
    public object TargetDirection { get; set; }

    [BinaryContent(Name = "TargetDir", NodeType = BinaryContentTypes.Attribute)]
    public object TargetDir { get; set; }

    [BinaryContent(Name = "StillWaitingForGroup", NodeType = BinaryContentTypes.Attribute)]
    public object StillWaitingForGroup { get; set; }

    [BinaryContent(Name = "MovementGroupID", NodeType = BinaryContentTypes.Attribute)]
    public object MovementGroupID { get; set; }

    [BinaryContent(Name = "EscortID", NodeType = BinaryContentTypes.Attribute)]
    public object EscortID { get; set; }

    [BinaryContent(Name = "EscortRadius", NodeType = BinaryContentTypes.Attribute)]
    public object EscortRadius { get; set; }

    [BinaryContent(Name = "Parent", NodeType = BinaryContentTypes.Node)]
    public Parent Parent { get; set; }

    [BinaryContent(Name = "DriftingInstruction", NodeType = BinaryContentTypes.Node)]
    public DriftingInstruction DriftingInstruction { get; set; }

    #endregion Public Properties
  }
}