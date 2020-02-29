using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class RunningQuestsList {

    [BinaryContent(Name = "questGUID", NodeType = BinaryContentTypes.Attribute)]
    public object QuestGUID { get; set; }

    [BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Attribute)]
    public object QuestID { get; set; }

    [BinaryContent(Name = "StartTime", NodeType = BinaryContentTypes.Attribute)]
    public object StartTime { get; set; }

    [BinaryContent(Name = "ActiveTime", NodeType = BinaryContentTypes.Attribute)]
    public object ActiveTime { get; set; }

    [BinaryContent(Name = "EndTime", NodeType = BinaryContentTypes.Attribute)]
    public object EndTime { get; set; }

    [BinaryContent(Name = "StartSessionGUID", NodeType = BinaryContentTypes.Attribute)]
    public object StartSessionGUID { get; set; }

    [BinaryContent(Name = "IsTimedQuest", NodeType = BinaryContentTypes.Attribute)]
    public object IsTimedQuest { get; set; }

    [BinaryContent(Name = "QuestState", NodeType = BinaryContentTypes.Node)]
    public QuestState QuestState { get; set; }

    [BinaryContent(Name = "QuestAssignee", NodeType = BinaryContentTypes.Node)]
    public QuestAssignee QuestAssignee { get; set; }

    [BinaryContent(Name = "AbortReason", NodeType = BinaryContentTypes.Node)]
    public AbortReason AbortReason { get; set; }

    [BinaryContent(Name = "QuestObjectives", NodeType = BinaryContentTypes.Node)]
    public QuestObjectives QuestObjectives { get; set; }

    [BinaryContent(Name = "RewardGenerator", NodeType = BinaryContentTypes.Node)]
    public RewardGenerator RewardGenerator { get; set; }

    [BinaryContent(Name = "StartQuestData", NodeType = BinaryContentTypes.Node)]
    public StartQuestData StartQuestData { get; set; }

    [BinaryContent(Name = "QuestMetaData", NodeType = BinaryContentTypes.Node)]
    public RunningQuestsListQuestMetaData QuestMetaData { get; set; }

  }
}