namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class ConditionsListActionsList {

    [BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Attribute)]
    public List<object> QuestID { get; set; }

    [BinaryContent(Name = "AssetGUID", NodeType = BinaryContentTypes.Attribute)]
    public List<object> AssetGUID { get; set; }

    [BinaryContent(Name = "ActionID", NodeType = BinaryContentTypes.Attribute)]
    public List<object> ActionID { get; set; }

    [BinaryContent(Name = "ScannerObjectID", NodeType = BinaryContentTypes.Attribute)]
    public object ScannerObjectID { get; set; }

    [BinaryContent(Name = "SpawnedObjects", NodeType = BinaryContentTypes.Attribute)]
    public object SpawnedObjects { get; set; }

    [BinaryContent(Name = "SpawnedScanner", NodeType = BinaryContentTypes.Attribute)]
    public object SpawnedScanner { get; set; }

    [BinaryContent(Name = "SpawnedInSessionGUID", NodeType = BinaryContentTypes.Attribute)]
    public object SpawnedInSessionGUID { get; set; }

    [BinaryContent(Name = "SpawnContextPosition", NodeType = BinaryContentTypes.Attribute)]
    public object SpawnContextPosition { get; set; }

    [BinaryContent(Name = "TargetArea", NodeType = BinaryContentTypes.Attribute)]
    public object TargetArea { get; set; }

    [BinaryContent(Name = "SetMenuVisible", NodeType = BinaryContentTypes.Attribute)]
    public object SetMenuVisible { get; set; }

    [BinaryContent(Name = "IsNetSafe", NodeType = BinaryContentTypes.Attribute)]
    public object IsNetSafe { get; set; }

    [BinaryContent(Name = "SpawnGUID", NodeType = BinaryContentTypes.Attribute)]
    public object SpawnGUID { get; set; }

    [BinaryContent(Name = "Amount", NodeType = BinaryContentTypes.Attribute)]
    public object Amount { get; set; }

    [BinaryContent(Name = "CollectCount", NodeType = BinaryContentTypes.Attribute)]
    public object CollectCount { get; set; }

    [BinaryContent(Name = "ConditionTutorialKey", NodeType = BinaryContentTypes.Attribute)]
    public object ConditionTutorialKey { get; set; }

    [BinaryContent(Name = "Quest", NodeType = BinaryContentTypes.Attribute)]
    public object Quest { get; set; }

    [BinaryContent(Name = "InheritQuestSession", NodeType = BinaryContentTypes.Attribute)]
    public object InheritQuestSession { get; set; }

    [BinaryContent(Name = "UnlockAssetGUID", NodeType = BinaryContentTypes.Attribute)]
    public object UnlockAssetGUID { get; set; }

    [BinaryContent(Name = "UnhideAssetGUID", NodeType = BinaryContentTypes.Attribute)]
    public object UnhideAssetGUID { get; set; }

    [BinaryContent(Name = "ModificationValue", NodeType = BinaryContentTypes.Attribute)]
    public object ModificationValue { get; set; }

    [BinaryContent(Name = "ClampVariableValue", NodeType = BinaryContentTypes.Attribute)]
    public object ClampVariableValue { get; set; }

    [BinaryContent(Name = "ClampValueMax", NodeType = BinaryContentTypes.Attribute)]
    public object ClampValueMax { get; set; }

    [BinaryContent(Name = "TriggerAsset", NodeType = BinaryContentTypes.Attribute)]
    public object TriggerAsset { get; set; }

    [BinaryContent(Name = "ExecutionDelay", NodeType = BinaryContentTypes.Attribute)]
    public object ExecutionDelay { get; set; }

    [BinaryContent(Name = "ChangeForProcessingParticipant", NodeType = BinaryContentTypes.Attribute)]
    public object ChangeForProcessingParticipant { get; set; }

    [BinaryContent(Name = "QuestPoolListToChange", NodeType = BinaryContentTypes.Attribute)]
    public object QuestPoolListToChange { get; set; }

    [BinaryContent(Name = "UnregisterTrigger", NodeType = BinaryContentTypes.Attribute)]
    public object UnregisterTrigger { get; set; }

    [BinaryContent(Name = "QuestGUID", NodeType = BinaryContentTypes.Attribute)]
    public object QuestGUID { get; set; }

    [BinaryContent(Name = "ResetAssetGUID", NodeType = BinaryContentTypes.Attribute)]
    public object ResetAssetGUID { get; set; }

    [BinaryContent(Name = "actionType", NodeType = BinaryContentTypes.Node)]
    public ConditionsListActionsListActionType ActionType { get; set; }

    [BinaryContent(Name = "Owner", NodeType = BinaryContentTypes.Node)]
    public ConditionsListActionsListOwner Owner { get; set; }

    [BinaryContent(Name = "VisualSpawnOwner", NodeType = BinaryContentTypes.Node)]
    public VisualSpawnOwner VisualSpawnOwner { get; set; }

    [BinaryContent(Name = "OwnerParticipant", NodeType = BinaryContentTypes.Node)]
    public List<ConditionsListActionsListOwnerParticipant> OwnerParticipant { get; set; }

    [BinaryContent(Name = "TargetPeer", NodeType = BinaryContentTypes.Node)]
    public List<ConditionsListActionsListTargetPeer> TargetPeer { get; set; }

    [BinaryContent(Name = "SpawnEntries", NodeType = BinaryContentTypes.Node)]
    public SpawnEntries SpawnEntries { get; set; }

    [BinaryContent(Name = "ParticipantID", NodeType = BinaryContentTypes.Node)]
    public ConditionsListActionsListParticipantID ParticipantID { get; set; }

    [BinaryContent(Name = "SpawnDescription", NodeType = BinaryContentTypes.Node)]
    public SpawnDescription SpawnDescription { get; set; }

    [BinaryContent(Name = "ScannerSpawnInfo", NodeType = BinaryContentTypes.Node)]
    public ScannerSpawnInfo ScannerSpawnInfo { get; set; }

    [BinaryContent(Name = "SessionFilter", NodeType = BinaryContentTypes.Node)]
    public SessionFilter SessionFilter { get; set; }

    [BinaryContent(Name = "DemandedGoods", NodeType = BinaryContentTypes.Node)]
    public DemandedGoods DemandedGoods { get; set; }

    [BinaryContent(Name = "TargetObjects", NodeType = BinaryContentTypes.Node)]
    public TargetObjects TargetObjects { get; set; }

    [BinaryContent(Name = "MenuType", NodeType = BinaryContentTypes.Node)]
    public MenuType MenuType { get; set; }

    [BinaryContent(Name = "Variable", NodeType = BinaryContentTypes.Node)]
    public ConditionsListActionsListVariable Variable { get; set; }

    [BinaryContent(Name = "Modifier", NodeType = BinaryContentTypes.Node)]
    public ConditionsListActionsListModifier Modifier { get; set; }

    [BinaryContent(Name = "ValueType", NodeType = BinaryContentTypes.Node)]
    public ConditionsListActionsListValueType ValueType { get; set; }

    [BinaryContent(Name = "VariableValue", NodeType = BinaryContentTypes.Node)]
    public VariableValue VariableValue { get; set; }

    [BinaryContent(Name = "ActionListSuccess", NodeType = BinaryContentTypes.Node)]
    public ActionListSuccess ActionListSuccess { get; set; }

    [BinaryContent(Name = "ActionListFailure", NodeType = BinaryContentTypes.Node)]
    public ActionListFailure ActionListFailure { get; set; }

    [BinaryContent(Name = "NotificationType", NodeType = BinaryContentTypes.Node)]
    public ConditionsListActionsListNotificationType NotificationType { get; set; }

    [BinaryContent(Name = "Notification", NodeType = BinaryContentTypes.Node)]
    public Notification Notification { get; set; }

    [BinaryContent(Name = "DelayVariable", NodeType = BinaryContentTypes.Node)]
    public ConditionsListActionsListDelayVariable DelayVariable { get; set; }

    [BinaryContent(Name = "QuestMetaData", NodeType = BinaryContentTypes.Node)]
    public ConditionsListActionsListQuestMetaData QuestMetaData { get; set; }

    [BinaryContent(Name = "DelayedActions", NodeType = BinaryContentTypes.Node)]
    public ConditionsListActionsListDelayedActions DelayedActions { get; set; }

    [BinaryContent(Name = "SpecifyParticipant", NodeType = BinaryContentTypes.Node)]
    public SpecifyParticipant SpecifyParticipant { get; set; }
  }
}