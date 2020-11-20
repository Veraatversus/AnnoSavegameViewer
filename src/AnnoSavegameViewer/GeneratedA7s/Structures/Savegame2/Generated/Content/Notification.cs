namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class Notification {

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
    public NotificationParticipantID ParticipantID { get; set; }

    [BinaryContent(Name = "ShowQuestRewards", NodeType = BinaryContentTypes.Node)]
    public ShowQuestRewards ShowQuestRewards { get; set; }

    [BinaryContent(Name = "Interactions", NodeType = BinaryContentTypes.Node)]
    public Interactions Interactions { get; set; }

    [BinaryContent(Name = "DefaultInteraction", NodeType = BinaryContentTypes.Node)]
    public DefaultInteraction DefaultInteraction { get; set; }

    [BinaryContent(Name = "RewardDataList", NodeType = BinaryContentTypes.Node)]
    public RewardDataList RewardDataList { get; set; }

    [BinaryContent(Name = "ReputationDataList", NodeType = BinaryContentTypes.Node)]
    public ReputationDataList ReputationDataList { get; set; }

    [BinaryContent(Name = "PenaltyDataList", NodeType = BinaryContentTypes.Node)]
    public PenaltyDataList PenaltyDataList { get; set; }

    [BinaryContent(Name = "StringReplacements", NodeType = BinaryContentTypes.Node)]
    public NotificationStringReplacements StringReplacements { get; set; }

    [BinaryContent(Name = "TextInfo", NodeType = BinaryContentTypes.Node)]
    public NotificationTextInfo TextInfo { get; set; }

    [BinaryContent(Name = "FilterType", NodeType = BinaryContentTypes.Node)]
    public NotificationFilterType FilterType { get; set; }

    [BinaryContent(Name = "Group", NodeType = BinaryContentTypes.Node)]
    public NotificationGroup Group { get; set; }

    [BinaryContent(Name = "TargetPeer", NodeType = BinaryContentTypes.Node)]
    public NotificationTargetPeer TargetPeer { get; set; }

    [BinaryContent(Name = "StartTime", NodeType = BinaryContentTypes.Node)]
    public NotificationStartTime StartTime { get; set; }

    [BinaryContent(Name = "EndTime", NodeType = BinaryContentTypes.Node)]
    public NotificationEndTime EndTime { get; set; }

  }
}