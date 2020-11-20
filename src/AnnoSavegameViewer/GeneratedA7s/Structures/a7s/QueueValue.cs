// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class QueueValue {

		[BinaryContent(Name = "NotificationType", NodeType = BinaryContentTypes.Node)]
		public NotificationType NotificationType { get; set; }

		[BinaryContent(Name = "SelectedTextGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString SelectedTextGUID { get; set; }

		[BinaryContent(Name = "ProfileGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ProfileGUID { get; set; }

		[BinaryContent(Name = "PortraitGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString PortraitGUID { get; set; }

		[BinaryContent(Name = "ParticipantID", NodeType = BinaryContentTypes.Node)]
		public NoneParticipantID ParticipantID { get; set; }

		[BinaryContent(Name = "SubtitleGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString SubtitleGUID { get; set; }

		[BinaryContent(Name = "SubtitleGroupID", NodeType = BinaryContentTypes.Attribute)]
		public HexString SubtitleGroupID { get; set; }

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

		[BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ID { get; set; }

		[BinaryContent(Name = "StringReplacements", NodeType = BinaryContentTypes.Node)]
		public StringReplacements StringReplacements { get; set; }

		[BinaryContent(Name = "SoundGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString SoundGUID { get; set; }

		[BinaryContent(Name = "MinDisplayTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString MinDisplayTime { get; set; }

		[BinaryContent(Name = "DisplayTimeout", NodeType = BinaryContentTypes.Attribute)]
		public HexString DisplayTimeout { get; set; }

		[BinaryContent(Name = "TextInfo", NodeType = BinaryContentTypes.Node)]
		public TextInfo TextInfo { get; set; }

		[BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
		public HexString AreaID { get; set; }

		[BinaryContent(Name = "FilterType", NodeType = BinaryContentTypes.Node)]
		public FilterType FilterType { get; set; }

		[BinaryContent(Name = "Priority", NodeType = BinaryContentTypes.Attribute)]
		public HexString Priority { get; set; }

		[BinaryContent(Name = "Group", NodeType = BinaryContentTypes.Node)]
		public Group Group { get; set; }

		[BinaryContent(Name = "TargetPeer", NodeType = BinaryContentTypes.Node)]
		public TargetPeer TargetPeer { get; set; }

		[BinaryContent(Name = "RestrictedToSessionOrRegions", NodeType = BinaryContentTypes.Attribute)]
		public HexString RestrictedToSessionOrRegions { get; set; }

		[BinaryContent(Name = "EnqueueTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString EnqueueTime { get; set; }

		[BinaryContent(Name = "StartTime", NodeType = BinaryContentTypes.Node)]
		public StartTime StartTime { get; set; }

		[BinaryContent(Name = "EndTime", NodeType = BinaryContentTypes.Node)]
		public EndTime EndTime { get; set; }

		[BinaryContent(Name = "TimeInPause", NodeType = BinaryContentTypes.Attribute)]
		public HexString TimeInPause { get; set; }

		[BinaryContent(Name = "ObjectID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ObjectID { get; set; }

		[BinaryContent(Name = "PositionSessionGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString PositionSessionGUID { get; set; }

		[BinaryContent(Name = "TextGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString TextGUID { get; set; }

		[BinaryContent(Name = "IconGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString IconGUID { get; set; }

		[BinaryContent(Name = "Infotip", NodeType = BinaryContentTypes.Attribute)]
		public HexString Infotip { get; set; }

		[BinaryContent(Name = "Category", NodeType = BinaryContentTypes.Node)]
		public Category Category { get; set; }

		[BinaryContent(Name = "hasInteraction", NodeType = BinaryContentTypes.Attribute)]
		public HexString HasInteraction { get; set; }

		[BinaryContent(Name = "Interaction", NodeType = BinaryContentTypes.Node)]
		public Interaction Interaction { get; set; }

		[BinaryContent(Name = "JumpLocation", NodeType = BinaryContentTypes.Attribute)]
		public HexString JumpLocation { get; set; }

	}
}
