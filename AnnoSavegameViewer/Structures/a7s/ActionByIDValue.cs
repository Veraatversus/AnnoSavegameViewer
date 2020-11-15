namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ActionByIDValue {

		[BinaryContent(Name = "actionType", NodeType = BinaryContentTypes.Node)]
		public ActionType ActionType { get; set; }

		[BinaryContent(Name = "actionID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ActionID { get; set; }

		[BinaryContent(Name = "UseVariableAsDelay", NodeType = BinaryContentTypes.Attribute)]
		public HexString UseVariableAsDelay { get; set; }

		[BinaryContent(Name = "DelayVariable", NodeType = BinaryContentTypes.Node)]
		public DelayVariable DelayVariable { get; set; }

		[BinaryContent(Name = "OwnerParticipant", NodeType = BinaryContentTypes.Node)]
		public OwnerParticipant OwnerParticipant { get; set; }

		[BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Attribute)]
		public HexString QuestID { get; set; }

		[BinaryContent(Name = "AssetGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString AssetGUID { get; set; }

		[BinaryContent(Name = "ActionID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ActionID2 { get; set; }

		[BinaryContent(Name = "TargetPeer", NodeType = BinaryContentTypes.Node)]
		public NoneTargetPeer TargetPeer { get; set; }

		[BinaryContent(Name = "QuestMetaData", NodeType = BinaryContentTypes.Node)]
		public NoneQuestMetaData QuestMetaData { get; set; }

		[BinaryContent(Name = "DelayedActions", NodeType = BinaryContentTypes.Node)]
		public DelayedActions DelayedActions { get; set; }

	}
}
