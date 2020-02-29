using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Walking {

    [BinaryContent(Name = "LastPos", NodeType = BinaryContentTypes.Attribute)]
    public object LastPos { get; set; }

    [BinaryContent(Name = "LastWaystepPos", NodeType = BinaryContentTypes.Attribute)]
    public object LastWaystepPos { get; set; }

    [BinaryContent(Name = "LastTickPos", NodeType = BinaryContentTypes.Attribute)]
    public object LastTickPos { get; set; }

    [BinaryContent(Name = "LastDirView", NodeType = BinaryContentTypes.Attribute)]
    public object LastDirView { get; set; }

    [BinaryContent(Name = "LastDirLogic", NodeType = BinaryContentTypes.Attribute)]
    public object LastDirLogic { get; set; }

    [BinaryContent(Name = "LastDeltaDirDelta", NodeType = BinaryContentTypes.Attribute)]
    public object LastDeltaDirDelta { get; set; }

    [BinaryContent(Name = "MovementGroupID", NodeType = BinaryContentTypes.Attribute)]
    public object MovementGroupID { get; set; }

    [BinaryContent(Name = "PreventDriftBack", NodeType = BinaryContentTypes.Attribute)]
    public object PreventDriftBack { get; set; }

    [BinaryContent(Name = "OldUnitID", NodeType = BinaryContentTypes.Attribute)]
    public object OldUnitID { get; set; }

    [BinaryContent(Name = "IdleTickCount", NodeType = BinaryContentTypes.Attribute)]
    public object IdleTickCount { get; set; }

    [BinaryContent(Name = "ExternalSpeedFactor", NodeType = BinaryContentTypes.Attribute)]
    public object ExternalSpeedFactor { get; set; }

    [BinaryContent(Name = "DriftingOffset", NodeType = BinaryContentTypes.Attribute)]
    public object DriftingOffset { get; set; }

    [BinaryContent(Name = "DriftingForce", NodeType = BinaryContentTypes.Attribute)]
    public object DriftingForce { get; set; }

    [BinaryContent(Name = "GroupBehaviourStance", NodeType = BinaryContentTypes.Attribute)]
    public object GroupBehaviourStance { get; set; }

    [BinaryContent(Name = "WayTime", NodeType = BinaryContentTypes.Attribute)]
    public object WayTime { get; set; }

    [BinaryContent(Name = "WasMovingLastTick", NodeType = BinaryContentTypes.Attribute)]
    public object WasMovingLastTick { get; set; }

    [BinaryContent(Name = "Moving", NodeType = BinaryContentTypes.Attribute)]
    public object Moving { get; set; }

    [BinaryContent(Name = "WasMoving", NodeType = BinaryContentTypes.Attribute)]
    public object WasMoving { get; set; }

    [BinaryContent(Name = "ForceReachWaytepRot", NodeType = BinaryContentTypes.Attribute)]
    public object ForceReachWaytepRot { get; set; }

    [BinaryContent(Name = "GroupOffset", NodeType = BinaryContentTypes.Attribute)]
    public object GroupOffset { get; set; }

    [BinaryContent(Name = "LeaningChanged", NodeType = BinaryContentTypes.Attribute)]
    public object LeaningChanged { get; set; }

    [BinaryContent(Name = "Leaning", NodeType = BinaryContentTypes.Attribute)]
    public object Leaning { get; set; }

    [BinaryContent(Name = "MovementGroupLevel", NodeType = BinaryContentTypes.Attribute)]
    public object MovementGroupLevel { get; set; }

    [BinaryContent(Name = "ArrivalTimer", NodeType = BinaryContentTypes.Attribute)]
    public object ArrivalTimer { get; set; }

    [BinaryContent(Name = "CatchUpFactor", NodeType = BinaryContentTypes.Attribute)]
    public object CatchUpFactor { get; set; }

    [BinaryContent(Name = "Reservation", NodeType = BinaryContentTypes.Node)]
    public Reservation Reservation { get; set; }

    [BinaryContent(Name = "Way", NodeType = BinaryContentTypes.Node)]
    public Way Way { get; set; }

    [BinaryContent(Name = "TargetPosition", NodeType = BinaryContentTypes.Node)]
    public TargetPosition TargetPosition { get; set; }

    [BinaryContent(Name = "CombatRange", NodeType = BinaryContentTypes.Node)]
    public CombatRange CombatRange { get; set; }

    [BinaryContent(Name = "PathBackground", NodeType = BinaryContentTypes.Node)]
    public PathBackground PathBackground { get; set; }

  }
}