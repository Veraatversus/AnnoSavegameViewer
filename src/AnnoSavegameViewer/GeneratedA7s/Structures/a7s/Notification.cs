// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class Notification {

		[BinaryContent(Name = "SelectedTextGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString SelectedTextGUID { get; set; }

		[BinaryContent(Name = "ProfileGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ProfileGUID { get; set; }

		[BinaryContent(Name = "PortraitGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString PortraitGUID { get; set; }

		[BinaryContent(Name = "ParticipantID", NodeType = BinaryContentTypes.Node)]
		public NotificationParticipantID ParticipantID { get; set; }

		[BinaryContent(Name = "SubtitleGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString SubtitleGUID { get; set; }

		[BinaryContent(Name = "ShowQuestRewards", NodeType = BinaryContentTypes.Node)]
		public NotificationShowQuestRewards ShowQuestRewards { get; set; }

		[BinaryContent(Name = "Interactions", NodeType = BinaryContentTypes.Node)]
		public NotificationInteractions Interactions { get; set; }

		[BinaryContent(Name = "DefaultInteraction", NodeType = BinaryContentTypes.Node)]
		public NotificationDefaultInteraction DefaultInteraction { get; set; }

		[BinaryContent(Name = "RewardDataList", NodeType = BinaryContentTypes.Node)]
		public NotificationRewardDataList RewardDataList { get; set; }

		[BinaryContent(Name = "ReputationDataList", NodeType = BinaryContentTypes.Node)]
		public NotificationReputationDataList ReputationDataList { get; set; }

		[BinaryContent(Name = "PenaltyDataList", NodeType = BinaryContentTypes.Node)]
		public NotificationPenaltyDataList PenaltyDataList { get; set; }

		[BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ID { get; set; }

		[BinaryContent(Name = "StringReplacements", NodeType = BinaryContentTypes.Node)]
		public NotificationStringReplacements StringReplacements { get; set; }

		[BinaryContent(Name = "MinDisplayTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString MinDisplayTime { get; set; }

		[BinaryContent(Name = "DisplayTimeout", NodeType = BinaryContentTypes.Attribute)]
		public HexString DisplayTimeout { get; set; }

		[BinaryContent(Name = "TextInfo", NodeType = BinaryContentTypes.Node)]
		public NotificationTextInfo TextInfo { get; set; }

		[BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
		public HexString AreaID { get; set; }

		[BinaryContent(Name = "FilterType", NodeType = BinaryContentTypes.Node)]
		public NotificationFilterType FilterType { get; set; }

		[BinaryContent(Name = "Priority", NodeType = BinaryContentTypes.Attribute)]
		public HexString Priority { get; set; }

		[BinaryContent(Name = "Group", NodeType = BinaryContentTypes.Node)]
		public NotificationGroup Group { get; set; }

		[BinaryContent(Name = "TargetPeer", NodeType = BinaryContentTypes.Node)]
		public NotificationTargetPeer TargetPeer { get; set; }

		[BinaryContent(Name = "RestrictedToSessionOrRegions", NodeType = BinaryContentTypes.Attribute)]
		public HexString RestrictedToSessionOrRegions { get; set; }

		[BinaryContent(Name = "EnqueueTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString EnqueueTime { get; set; }

		[BinaryContent(Name = "StartTime", NodeType = BinaryContentTypes.Node)]
		public NotificationStartTime StartTime { get; set; }

		[BinaryContent(Name = "EndTime", NodeType = BinaryContentTypes.Node)]
		public NotificationEndTime EndTime { get; set; }

		[BinaryContent(Name = "TimeInPause", NodeType = BinaryContentTypes.Attribute)]
		public HexString TimeInPause { get; set; }

		[BinaryContent(Name = "ObjectID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ObjectID { get; set; }

	}
}
