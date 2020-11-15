using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ActionListFailureValue {

[BinaryContent(Name = "actionType", NodeType = BinaryContentTypes.Node)]
public ActionListFailureValuesNoneActionType ActionType { get; set; }

[BinaryContent(Name = "OwnerParticipant", NodeType = BinaryContentTypes.Node)]
public ActionListFailureValuesNoneOwnerParticipant OwnerParticipant { get; set; }

[BinaryContent(Name = "AssetGUID", NodeType = BinaryContentTypes.Attribute)]
public HexString AssetGUID { get; set; }

[BinaryContent(Name = "ActionID", NodeType = BinaryContentTypes.Attribute)]
public HexString ActionID { get; set; }

[BinaryContent(Name = "TargetPeer", NodeType = BinaryContentTypes.Node)]
public ActionListFailureValuesNoneTargetPeer TargetPeer { get; set; }

}
}
