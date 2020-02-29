using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ConditionsListActionsListDelayedActionsList {

    #region Public Properties

    [BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Attribute)]
    public object QuestID { get; set; }

    [BinaryContent(Name = "AssetGUID", NodeType = BinaryContentTypes.Attribute)]
    public object AssetGUID { get; set; }

    [BinaryContent(Name = "IsNetSafe", NodeType = BinaryContentTypes.Attribute)]
    public object IsNetSafe { get; set; }

    [BinaryContent(Name = "ActionID", NodeType = BinaryContentTypes.Attribute)]
    public object ActionID { get; set; }

    [BinaryContent(Name = "TriggerAsset", NodeType = BinaryContentTypes.Attribute)]
    public object TriggerAsset { get; set; }

    [BinaryContent(Name = "actionType", NodeType = BinaryContentTypes.Node)]
    public ConditionsListActionsListDelayedActionsListActionType ActionType { get; set; }

    [BinaryContent(Name = "OwnerParticipant", NodeType = BinaryContentTypes.Node)]
    public ConditionsListActionsListDelayedActionsListOwnerParticipant OwnerParticipant { get; set; }

    [BinaryContent(Name = "TargetPeer", NodeType = BinaryContentTypes.Node)]
    public ConditionsListActionsListDelayedActionsListTargetPeer TargetPeer { get; set; }

    [BinaryContent(Name = "NotificationType", NodeType = BinaryContentTypes.Node)]
    public NotificationType NotificationType { get; set; }

    [BinaryContent(Name = "Notification", NodeType = BinaryContentTypes.Node)]
    public Notification Notification { get; set; }

    [BinaryContent(Name = "ObjectFilter", NodeType = BinaryContentTypes.Node)]
    public ObjectFilter ObjectFilter { get; set; }

    #endregion Public Properties
  }
}