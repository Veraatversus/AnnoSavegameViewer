namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class ConditionsListActionsListDelayedActionsListNotification {

    #region Public Properties

    [BinaryContent(Name = "SelectedTextGUID", NodeType = BinaryContentTypes.Attribute)]
    public object SelectedTextGUID { get; set; }

    [BinaryContent(Name = "ProfileGUID", NodeType = BinaryContentTypes.Attribute)]
    public object ProfileGUID { get; set; }

    [BinaryContent(Name = "PortraitGUID", NodeType = BinaryContentTypes.Attribute)]
    public object PortraitGUID { get; set; }

    [BinaryContent(Name = "SubtitleGUID", NodeType = BinaryContentTypes.Attribute)]
    public object SubtitleGUID { get; set; }

    [BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
    public object ID { get; set; }

    [BinaryContent(Name = "MinDisplayTime", NodeType = BinaryContentTypes.Attribute)]
    public object MinDisplayTime { get; set; }

    [BinaryContent(Name = "DisplayTimeout", NodeType = BinaryContentTypes.Attribute)]
    public object DisplayTimeout { get; set; }

    [BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
    public object AreaID { get; set; }

    [BinaryContent(Name = "Priority", NodeType = BinaryContentTypes.Attribute)]
    public object Priority { get; set; }

    [BinaryContent(Name = "RestrictedToSessionOrRegions", NodeType = BinaryContentTypes.Attribute)]
    public object RestrictedToSessionOrRegions { get; set; }

    [BinaryContent(Name = "EnqueueTime", NodeType = BinaryContentTypes.Attribute)]
    public object EnqueueTime { get; set; }

    [BinaryContent(Name = "TimeInPause", NodeType = BinaryContentTypes.Attribute)]
    public object TimeInPause { get; set; }

    [BinaryContent(Name = "ObjectID", NodeType = BinaryContentTypes.Attribute)]
    public object ObjectID { get; set; }

    [BinaryContent(Name = "ParticipantID", NodeType = BinaryContentTypes.Node)]
    public ConditionsListActionsListDelayedActionsListNotificationParticipantID ParticipantID { get; set; }

    [BinaryContent(Name = "ShowQuestRewards", NodeType = BinaryContentTypes.Node)]
    public ConditionsListActionsListDelayedActionsListNotificationShowQuestRewards ShowQuestRewards { get; set; }

    [BinaryContent(Name = "Interactions", NodeType = BinaryContentTypes.Node)]
    public ConditionsListActionsListDelayedActionsListNotificationInteractions Interactions { get; set; }

    [BinaryContent(Name = "DefaultInteraction", NodeType = BinaryContentTypes.Node)]
    public ConditionsListActionsListDelayedActionsListNotificationDefaultInteraction DefaultInteraction { get; set; }

    [BinaryContent(Name = "RewardDataList", NodeType = BinaryContentTypes.Node)]
    public ConditionsListActionsListDelayedActionsListNotificationRewardDataList RewardDataList { get; set; }

    [BinaryContent(Name = "ReputationDataList", NodeType = BinaryContentTypes.Node)]
    public ConditionsListActionsListDelayedActionsListNotificationReputationDataList ReputationDataList { get; set; }

    [BinaryContent(Name = "PenaltyDataList", NodeType = BinaryContentTypes.Node)]
    public ConditionsListActionsListDelayedActionsListNotificationPenaltyDataList PenaltyDataList { get; set; }

    [BinaryContent(Name = "StringReplacements", NodeType = BinaryContentTypes.Node)]
    public ConditionsListActionsListDelayedActionsListNotificationStringReplacements StringReplacements { get; set; }

    [BinaryContent(Name = "TextInfo", NodeType = BinaryContentTypes.Node)]
    public ConditionsListActionsListDelayedActionsListNotificationTextInfo TextInfo { get; set; }

    [BinaryContent(Name = "FilterType", NodeType = BinaryContentTypes.Node)]
    public ConditionsListActionsListDelayedActionsListNotificationFilterType FilterType { get; set; }

    [BinaryContent(Name = "Group", NodeType = BinaryContentTypes.Node)]
    public ConditionsListActionsListDelayedActionsListNotificationGroup Group { get; set; }

    [BinaryContent(Name = "TargetPeer", NodeType = BinaryContentTypes.Node)]
    public ConditionsListActionsListDelayedActionsListNotificationTargetPeer TargetPeer { get; set; }

    [BinaryContent(Name = "StartTime", NodeType = BinaryContentTypes.Node)]
    public ConditionsListActionsListDelayedActionsListNotificationStartTime StartTime { get; set; }

    [BinaryContent(Name = "EndTime", NodeType = BinaryContentTypes.Node)]
    public ConditionsListActionsListDelayedActionsListNotificationEndTime EndTime { get; set; }

    #endregion Public Properties
  }
}