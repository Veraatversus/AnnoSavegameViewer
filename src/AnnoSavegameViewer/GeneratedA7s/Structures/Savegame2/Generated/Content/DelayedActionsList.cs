namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class DelayedActionsList {

    [BinaryContent(Name = "Quest", NodeType = BinaryContentTypes.Attribute)]
    public object Quest { get; set; }

    [BinaryContent(Name = "InheritQuestArea", NodeType = BinaryContentTypes.Attribute)]
    public object InheritQuestArea { get; set; }

    [BinaryContent(Name = "QuestSession", NodeType = BinaryContentTypes.Attribute)]
    public object QuestSession { get; set; }

    [BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Attribute)]
    public object QuestID { get; set; }

    [BinaryContent(Name = "AssetGUID", NodeType = BinaryContentTypes.Attribute)]
    public object AssetGUID { get; set; }

    [BinaryContent(Name = "ActionID", NodeType = BinaryContentTypes.Attribute)]
    public object ActionID { get; set; }

    [BinaryContent(Name = "actionType", NodeType = BinaryContentTypes.Node)]
    public DelayedActionsListActionType ActionType { get; set; }

    [BinaryContent(Name = "OwnerParticipant", NodeType = BinaryContentTypes.Node)]
    public DelayedActionsListOwnerParticipant OwnerParticipant { get; set; }

    [BinaryContent(Name = "TargetPeer", NodeType = BinaryContentTypes.Node)]
    public DelayedActionsListTargetPeer TargetPeer { get; set; }

    [BinaryContent(Name = "Variable", NodeType = BinaryContentTypes.Node)]
    public Variable Variable { get; set; }

    [BinaryContent(Name = "Modifier", NodeType = BinaryContentTypes.Node)]
    public Modifier Modifier { get; set; }

    [BinaryContent(Name = "ValueType", NodeType = BinaryContentTypes.Node)]
    public DelayedActionsListValueType ValueType { get; set; }
  }
}