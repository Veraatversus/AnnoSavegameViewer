using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class DelayedActionsValue {

[BinaryContent(Name = "actionType", NodeType = BinaryContentTypes.Node)]
public ValuesNoneActionType ActionType { get; set; }

[BinaryContent(Name = "Quest", NodeType = BinaryContentTypes.Attribute)]
public HexString Quest { get; set; }

[BinaryContent(Name = "InheritQuestArea", NodeType = BinaryContentTypes.Attribute)]
public HexString InheritQuestArea { get; set; }

[BinaryContent(Name = "QuestSession", NodeType = BinaryContentTypes.Attribute)]
public HexString QuestSession { get; set; }

[BinaryContent(Name = "OwnerParticipant", NodeType = BinaryContentTypes.Node)]
public ValuesNoneOwnerParticipant OwnerParticipant { get; set; }

[BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Attribute)]
public HexString QuestID { get; set; }

[BinaryContent(Name = "AssetGUID", NodeType = BinaryContentTypes.Attribute)]
public HexString AssetGUID { get; set; }

[BinaryContent(Name = "ActionID", NodeType = BinaryContentTypes.Attribute)]
public HexString ActionID { get; set; }

[BinaryContent(Name = "TargetPeer", NodeType = BinaryContentTypes.Node)]
public DelayedActionsValuesNoneTargetPeer TargetPeer { get; set; }

[BinaryContent(Name = "Variable", NodeType = BinaryContentTypes.Node)]
public NoneVariable Variable { get; set; }

[BinaryContent(Name = "Modifier", NodeType = BinaryContentTypes.Node)]
public NoneModifier Modifier { get; set; }

[BinaryContent(Name = "ValueType", NodeType = BinaryContentTypes.Node)]
public ValuesNoneValueType ValueType { get; set; }

}
}
