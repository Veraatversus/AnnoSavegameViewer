namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class QuestMetaData {

		[BinaryContent(Name = "QuestArea", NodeType = BinaryContentTypes.Attribute)]
		public HexString QuestArea { get; set; }

		[BinaryContent(Name = "RelatedQuestGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString RelatedQuestGUID { get; set; }

	}
}
