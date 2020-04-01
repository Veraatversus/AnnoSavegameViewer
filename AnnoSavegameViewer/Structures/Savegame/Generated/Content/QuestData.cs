using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class QuestData {

    [BinaryContent(Name = "ShowMainSubobjective", NodeType = BinaryContentTypes.Attribute)]
    public object ShowMainSubobjective { get; set; }

    [BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Attribute)]
    public object QuestID { get; set; }

    [BinaryContent(Name = "ConditionTextGUID", NodeType = BinaryContentTypes.Attribute)]
    public object ConditionTextGUID { get; set; }

    [BinaryContent(Name = "ShowInQuestTracker", NodeType = BinaryContentTypes.Attribute)]
    public object ShowInQuestTracker { get; set; }

    [BinaryContent(Name = "IsMainObjective", NodeType = BinaryContentTypes.Attribute)]
    public object IsMainObjective { get; set; }

    [BinaryContent(Name = "SuccessorObjectiveID", NodeType = BinaryContentTypes.Attribute)]
    public object SuccessorObjectiveID { get; set; }

    [BinaryContent(Name = "ObjectiveIndex", NodeType = BinaryContentTypes.Attribute)]
    public object ObjectiveIndex { get; set; }

    [BinaryContent(Name = "QuestTrackerIcon", NodeType = BinaryContentTypes.Attribute)]
    public object QuestTrackerIcon { get; set; }

    [BinaryContent(Name = "JumpToVisibility", NodeType = BinaryContentTypes.Node)]
    public JumpToVisibility JumpToVisibility { get; set; }

  }
}