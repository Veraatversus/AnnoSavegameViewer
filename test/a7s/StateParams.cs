using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class StateParams {

[BinaryContent(Name = "PtPos", NodeType = BinaryContentTypes.Attribute)]
public HexString PtPos { get; set; }

[BinaryContent(Name = "Radius", NodeType = BinaryContentTypes.Attribute)]
public HexString Radius { get; set; }

[BinaryContent(Name = "Object", NodeType = BinaryContentTypes.Node)]
public Object Object { get; set; }

[BinaryContent(Name = "AttachRadius", NodeType = BinaryContentTypes.Attribute)]
public HexString AttachRadius { get; set; }

[BinaryContent(Name = "AttachObject", NodeType = BinaryContentTypes.Node)]
public AttachObject AttachObject { get; set; }

[BinaryContent(Name = "SessionTranferInfo", NodeType = BinaryContentTypes.Node)]
public SessionTranferInfo SessionTranferInfo { get; set; }

[BinaryContent(Name = "StateOnQuitPassiveAttack", NodeType = BinaryContentTypes.Node)]
public StateOnQuitPassiveAttack StateOnQuitPassiveAttack { get; set; }

[BinaryContent(Name = "OptimalAttackMovementData", NodeType = BinaryContentTypes.Node)]
public OptimalAttackMovementData OptimalAttackMovementData { get; set; }

[BinaryContent(Name = "TargetStoppedMoving", NodeType = BinaryContentTypes.Attribute)]
public HexString TargetStoppedMoving { get; set; }

[BinaryContent(Name = "m_AllowTakeControllOnBeeingAttacked", NodeType = BinaryContentTypes.Attribute)]
public HexString M_AllowTakeControllOnBeeingAttacked { get; set; }

[BinaryContent(Name = "HasOptimalAttackMovementData", NodeType = BinaryContentTypes.Attribute)]
public HexString HasOptimalAttackMovementData { get; set; }

}
}
