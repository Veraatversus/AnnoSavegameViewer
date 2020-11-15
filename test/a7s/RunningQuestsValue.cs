using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class RunningQuestsValue {

[BinaryContent(Name = "questGUID", NodeType = BinaryContentTypes.Attribute)]
public HexString QuestGUID { get; set; }

[BinaryContent(Name = "QuestState", NodeType = BinaryContentTypes.Node)]
public QuestState QuestState { get; set; }

[BinaryContent(Name = "QuestAssignee", NodeType = BinaryContentTypes.Node)]
public QuestAssignee QuestAssignee { get; set; }

[BinaryContent(Name = "AbortReason", NodeType = BinaryContentTypes.Node)]
public AbortReason AbortReason { get; set; }

[BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Attribute)]
public HexString QuestID { get; set; }

[BinaryContent(Name = "StartTime", NodeType = BinaryContentTypes.Attribute)]
public HexString StartTime { get; set; }

[BinaryContent(Name = "ActiveTime", NodeType = BinaryContentTypes.Attribute)]
public HexString ActiveTime { get; set; }

[BinaryContent(Name = "EndTime", NodeType = BinaryContentTypes.Attribute)]
public HexString EndTime { get; set; }

[BinaryContent(Name = "QuestObjectives", NodeType = BinaryContentTypes.Node)]
public QuestObjectives QuestObjectives { get; set; }

[BinaryContent(Name = "RewardGenerator", NodeType = BinaryContentTypes.Node)]
public RewardGenerator RewardGenerator { get; set; }

[BinaryContent(Name = "StartQuestData", NodeType = BinaryContentTypes.Node)]
public StartQuestData StartQuestData { get; set; }

[BinaryContent(Name = "StartSessionGUID", NodeType = BinaryContentTypes.Attribute)]
public HexString StartSessionGUID { get; set; }

[BinaryContent(Name = "QuestMetaData", NodeType = BinaryContentTypes.Node)]
public QuestMetaData QuestMetaData { get; set; }

[BinaryContent(Name = "IsTimedQuest", NodeType = BinaryContentTypes.Attribute)]
public HexString IsTimedQuest { get; set; }

}
}
