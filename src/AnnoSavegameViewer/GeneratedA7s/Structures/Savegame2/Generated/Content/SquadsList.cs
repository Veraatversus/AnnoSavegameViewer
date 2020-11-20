namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class SquadsList {

    [BinaryContent(Name = "mapKey", NodeType = BinaryContentTypes.Attribute)]
    public object MapKey { get; set; }

    [BinaryContent(Name = "mapContext", NodeType = BinaryContentTypes.Attribute)]
    public object MapContext { get; set; }

    [BinaryContent(Name = "LastAITick", NodeType = BinaryContentTypes.Attribute)]
    public object LastAITick { get; set; }

    [BinaryContent(Name = "m_SquadID", NodeType = BinaryContentTypes.Attribute)]
    public object M_SquadID { get; set; }

    [BinaryContent(Name = "taskQueueSize", NodeType = BinaryContentTypes.Attribute)]
    public object TaskQueueSize { get; set; }

    [BinaryContent(Name = "taskType", NodeType = BinaryContentTypes.Attribute)]
    public object TaskType { get; set; }

    [BinaryContent(Name = "RoutePoints", NodeType = BinaryContentTypes.Attribute)]
    public object RoutePoints { get; set; }

    [BinaryContent(Name = "RoutePausedSince", NodeType = BinaryContentTypes.Attribute)]
    public object RoutePausedSince { get; set; }

    [BinaryContent(Name = "ReverseDirection", NodeType = BinaryContentTypes.Attribute)]
    public object ReverseDirection { get; set; }

    [BinaryContent(Name = "EscortID", NodeType = BinaryContentTypes.Attribute)]
    public object EscortID { get; set; }

    [BinaryContent(Name = "CurrentPointIndex", NodeType = BinaryContentTypes.Attribute)]
    public object CurrentPointIndex { get; set; }

    [BinaryContent(Name = "TargetPosition", NodeType = BinaryContentTypes.Attribute)]
    public object TargetPosition { get; set; }

    [BinaryContent(Name = "EscortPriority", NodeType = BinaryContentTypes.Attribute)]
    public object EscortPriority { get; set; }

    [BinaryContent(Name = "m_PathPlannerLayer", NodeType = BinaryContentTypes.Node)]
    public M_PathPlannerLayer M_PathPlannerLayer { get; set; }

    [BinaryContent(Name = "SquadUnits", NodeType = BinaryContentTypes.Node)]
    public SquadUnits SquadUnits { get; set; }

    [BinaryContent(Name = "ParticipantID", NodeType = BinaryContentTypes.Node)]
    public SquadsListParticipantID ParticipantID { get; set; }

  }
}