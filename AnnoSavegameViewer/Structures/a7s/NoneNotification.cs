namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class NoneNotification {

		[BinaryContent(Name = "SelectedTextGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString SelectedTextGUID { get; set; }

		[BinaryContent(Name = "ProfileGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ProfileGUID { get; set; }

		[BinaryContent(Name = "PortraitGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString PortraitGUID { get; set; }

		[BinaryContent(Name = "ParticipantID", NodeType = BinaryContentTypes.Node)]
		public NoneNotificationParticipantID ParticipantID { get; set; }

		[BinaryContent(Name = "SubtitleGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString SubtitleGUID { get; set; }

		[BinaryContent(Name = "ShowQuestRewards", NodeType = BinaryContentTypes.Node)]
		public NoneNotificationShowQuestRewards ShowQuestRewards { get; set; }

		[BinaryContent(Name = "Interactions", NodeType = BinaryContentTypes.Node)]
		public NoneNotificationInteractions Interactions { get; set; }

		[BinaryContent(Name = "DefaultInteraction", NodeType = BinaryContentTypes.Node)]
		public NoneNotificationDefaultInteraction DefaultInteraction { get; set; }

		[BinaryContent(Name = "RewardDataList", NodeType = BinaryContentTypes.Node)]
		public NoneNotificationRewardDataList RewardDataList { get; set; }

		[BinaryContent(Name = "ReputationDataList", NodeType = BinaryContentTypes.Node)]
		public NoneNotificationReputationDataList ReputationDataList { get; set; }

		[BinaryContent(Name = "PenaltyDataList", NodeType = BinaryContentTypes.Node)]
		public NoneNotificationPenaltyDataList PenaltyDataList { get; set; }

		[BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ID { get; set; }

		[BinaryContent(Name = "StringReplacements", NodeType = BinaryContentTypes.Node)]
		public NoneNotificationStringReplacements StringReplacements { get; set; }

		[BinaryContent(Name = "MinDisplayTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString MinDisplayTime { get; set; }

		[BinaryContent(Name = "DisplayTimeout", NodeType = BinaryContentTypes.Attribute)]
		public HexString DisplayTimeout { get; set; }

		[BinaryContent(Name = "TextInfo", NodeType = BinaryContentTypes.Node)]
		public NoneNotificationTextInfo TextInfo { get; set; }

		[BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
		public HexString AreaID { get; set; }

		[BinaryContent(Name = "FilterType", NodeType = BinaryContentTypes.Node)]
		public NoneNotificationFilterType FilterType { get; set; }

		[BinaryContent(Name = "Priority", NodeType = BinaryContentTypes.Attribute)]
		public HexString Priority { get; set; }

		[BinaryContent(Name = "Group", NodeType = BinaryContentTypes.Node)]
		public NoneNotificationGroup Group { get; set; }

		[BinaryContent(Name = "TargetPeer", NodeType = BinaryContentTypes.Node)]
		public NoneNotificationTargetPeer TargetPeer { get; set; }

		[BinaryContent(Name = "RestrictedToSessionOrRegions", NodeType = BinaryContentTypes.Attribute)]
		public HexString RestrictedToSessionOrRegions { get; set; }

		[BinaryContent(Name = "EnqueueTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString EnqueueTime { get; set; }

		[BinaryContent(Name = "StartTime", NodeType = BinaryContentTypes.Node)]
		public NoneNotificationStartTime StartTime { get; set; }

		[BinaryContent(Name = "EndTime", NodeType = BinaryContentTypes.Node)]
		public NoneNotificationEndTime EndTime { get; set; }

		[BinaryContent(Name = "TimeInPause", NodeType = BinaryContentTypes.Attribute)]
		public HexString TimeInPause { get; set; }

		[BinaryContent(Name = "ObjectID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ObjectID { get; set; }

	}
}
