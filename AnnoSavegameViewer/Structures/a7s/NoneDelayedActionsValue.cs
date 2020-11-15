namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class NoneDelayedActionsValue {

		[BinaryContent(Name = "actionType", NodeType = BinaryContentTypes.Node)]
		public DelayedActionsValuesNoneActionType ActionType { get; set; }

		[BinaryContent(Name = "Quest", NodeType = BinaryContentTypes.Attribute)]
		public HexString Quest { get; set; }

		[BinaryContent(Name = "QuestSession", NodeType = BinaryContentTypes.Attribute)]
		public HexString QuestSession { get; set; }

		[BinaryContent(Name = "OwnerParticipant", NodeType = BinaryContentTypes.Node)]
		public DelayedActionsValuesNoneOwnerParticipant OwnerParticipant { get; set; }

		[BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Attribute)]
		public HexString QuestID { get; set; }

		[BinaryContent(Name = "AssetGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString AssetGUID { get; set; }

		[BinaryContent(Name = "ActionID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ActionID { get; set; }

		[BinaryContent(Name = "TargetPeer", NodeType = BinaryContentTypes.Node)]
		public NoneDelayedActionsValuesNoneTargetPeer TargetPeer { get; set; }

		[BinaryContent(Name = "IsNetSafe", NodeType = BinaryContentTypes.Attribute)]
		public HexString IsNetSafe { get; set; }

		[BinaryContent(Name = "NotificationType", NodeType = BinaryContentTypes.Node)]
		public ValuesNoneNotificationType NotificationType { get; set; }

		[BinaryContent(Name = "Notification", NodeType = BinaryContentTypes.Node)]
		public NoneNotification Notification { get; set; }

		[BinaryContent(Name = "ObjectFilter", NodeType = BinaryContentTypes.Node)]
		public DelayedActionsValuesNoneObjectFilter ObjectFilter { get; set; }

		[BinaryContent(Name = "TriggerAsset", NodeType = BinaryContentTypes.Attribute)]
		public HexString TriggerAsset { get; set; }

	}
}
