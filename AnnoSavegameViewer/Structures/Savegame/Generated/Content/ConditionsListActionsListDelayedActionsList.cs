using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ConditionsListActionsListDelayedActionsList {

    [BinaryContent(Name = "Quest", NodeType = BinaryContentTypes.Attribute)]
    public object Quest { get; set; }

    [BinaryContent(Name = "QuestSession", NodeType = BinaryContentTypes.Attribute)]
    public object QuestSession { get; set; }

    [BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Attribute)]
    public object QuestID { get; set; }

    [BinaryContent(Name = "AssetGUID", NodeType = BinaryContentTypes.Attribute)]
    public object AssetGUID { get; set; }

    [BinaryContent(Name = "ActionID", NodeType = BinaryContentTypes.Attribute)]
    public object ActionID { get; set; }

    [BinaryContent(Name = "IsNetSafe", NodeType = BinaryContentTypes.Attribute)]
    public object IsNetSafe { get; set; }

    [BinaryContent(Name = "TriggerAsset", NodeType = BinaryContentTypes.Attribute)]
    public object TriggerAsset { get; set; }

    [BinaryContent(Name = "actionType", NodeType = BinaryContentTypes.Node)]
    public ConditionsListActionsListDelayedActionsListActionType ActionType { get; set; }

    [BinaryContent(Name = "OwnerParticipant", NodeType = BinaryContentTypes.Node)]
    public ConditionsListActionsListDelayedActionsListOwnerParticipant OwnerParticipant { get; set; }

    [BinaryContent(Name = "TargetPeer", NodeType = BinaryContentTypes.Node)]
    public ConditionsListActionsListDelayedActionsListTargetPeer TargetPeer { get; set; }

    [BinaryContent(Name = "NotificationType", NodeType = BinaryContentTypes.Node)]
    public ConditionsListActionsListDelayedActionsListNotificationType NotificationType { get; set; }

    [BinaryContent(Name = "Notification", NodeType = BinaryContentTypes.Node)]
    public ConditionsListActionsListDelayedActionsListNotification Notification { get; set; }

    [BinaryContent(Name = "ObjectFilter", NodeType = BinaryContentTypes.Node)]
    public ObjectFilter ObjectFilter { get; set; }

  }
}