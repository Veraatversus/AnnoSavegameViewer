using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class StateParams {

    [BinaryContent(Name = "PtPos", NodeType = BinaryContentTypes.Attribute)]
    public object PtPos { get; set; }

    [BinaryContent(Name = "Radius", NodeType = BinaryContentTypes.Attribute)]
    public object Radius { get; set; }

    [BinaryContent(Name = "AttachRadius", NodeType = BinaryContentTypes.Attribute)]
    public object AttachRadius { get; set; }

    [BinaryContent(Name = "EscortedObjectMetaID", NodeType = BinaryContentTypes.Attribute)]
    public object EscortedObjectMetaID { get; set; }

    [BinaryContent(Name = "GroupID", NodeType = BinaryContentTypes.Attribute)]
    public object GroupID { get; set; }

    [BinaryContent(Name = "m_AllowTakeControllOnBeeingAttacked", NodeType = BinaryContentTypes.Attribute)]
    public object M_AllowTakeControllOnBeeingAttacked { get; set; }

    [BinaryContent(Name = "GroupOffset", NodeType = BinaryContentTypes.Attribute)]
    public object GroupOffset { get; set; }

    [BinaryContent(Name = "HasOptimalAttackMovementData", NodeType = BinaryContentTypes.Attribute)]
    public object HasOptimalAttackMovementData { get; set; }

    [BinaryContent(Name = "TargetStoppedMoving", NodeType = BinaryContentTypes.Attribute)]
    public object TargetStoppedMoving { get; set; }

    [BinaryContent(Name = "HasDesiredOffsetToTarget", NodeType = BinaryContentTypes.Attribute)]
    public object HasDesiredOffsetToTarget { get; set; }

    [BinaryContent(Name = "DesiredOffsetToTarget", NodeType = BinaryContentTypes.Attribute)]
    public object DesiredOffsetToTarget { get; set; }

    [BinaryContent(Name = "GroupLevel", NodeType = BinaryContentTypes.Attribute)]
    public object GroupLevel { get; set; }

    [BinaryContent(Name = "Object", NodeType = BinaryContentTypes.Node)]
    public StateParamsObject Object { get; set; }

    [BinaryContent(Name = "AttachObject", NodeType = BinaryContentTypes.Node)]
    public AttachObject AttachObject { get; set; }

    [BinaryContent(Name = "StateOnQuitPassiveAttack", NodeType = BinaryContentTypes.Node)]
    public StateOnQuitPassiveAttack StateOnQuitPassiveAttack { get; set; }

    [BinaryContent(Name = "OptimalAttackMovementData", NodeType = BinaryContentTypes.Node)]
    public OptimalAttackMovementData OptimalAttackMovementData { get; set; }

  }
}