namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ActionListSuccessValue {

		[BinaryContent(Name = "actionType", NodeType = BinaryContentTypes.Node)]
		public ActionListSuccessValuesNoneActionType ActionType { get; set; }

		[BinaryContent(Name = "Quest", NodeType = BinaryContentTypes.Attribute)]
		public HexString Quest { get; set; }

		[BinaryContent(Name = "QuestSession", NodeType = BinaryContentTypes.Attribute)]
		public HexString QuestSession { get; set; }

		[BinaryContent(Name = "OwnerParticipant", NodeType = BinaryContentTypes.Node)]
		public ActionListSuccessValuesNoneOwnerParticipant OwnerParticipant { get; set; }

		[BinaryContent(Name = "AssetGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString AssetGUID { get; set; }

		[BinaryContent(Name = "ActionID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ActionID { get; set; }

		[BinaryContent(Name = "TargetPeer", NodeType = BinaryContentTypes.Node)]
		public ActionListSuccessValuesNoneTargetPeer TargetPeer { get; set; }

		[BinaryContent(Name = "OpenNewspaperType", NodeType = BinaryContentTypes.Node)]
		public NoneOpenNewspaperType OpenNewspaperType { get; set; }

		[BinaryContent(Name = "ShowPamsyMessage", NodeType = BinaryContentTypes.Attribute)]
		public HexString ShowPamsyMessage { get; set; }

		[BinaryContent(Name = "Articles", NodeType = BinaryContentTypes.Attribute)]
		public HexString Articles { get; set; }

		[BinaryContent(Name = "PictureArea", NodeType = BinaryContentTypes.Attribute)]
		public HexString PictureArea { get; set; }

	}
}
