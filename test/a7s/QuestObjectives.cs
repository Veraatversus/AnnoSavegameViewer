using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class QuestObjectives {

[BinaryContent(Name = "ConditionKey", NodeType = BinaryContentTypes.Attribute)]
public HexString ConditionKey { get; set; }

[BinaryContent(Name = "ConditionHistory", NodeType = BinaryContentTypes.Node)]
public ConditionHistory ConditionHistory { get; set; }

[BinaryContent(Name = "ResultPlaceTargets", NodeType = BinaryContentTypes.Node)]
public ResultPlaceTargets ResultPlaceTargets { get; set; }

[BinaryContent(Name = "SuccessConditions", NodeType = BinaryContentTypes.Node)]
public SuccessConditions SuccessConditions { get; set; }

[BinaryContent(Name = "DelayedSuccessMessages", NodeType = BinaryContentTypes.Node)]
public DelayedSuccessMessages DelayedSuccessMessages { get; set; }

}
}
