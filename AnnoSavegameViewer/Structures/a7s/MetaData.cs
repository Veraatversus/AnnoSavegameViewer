namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class MetaData {

		[BinaryContent(Name = "QuestArea", NodeType = BinaryContentTypes.Attribute)]
		public Int16 QuestArea { get; set; }

		[BinaryContent(Name = "RelatedQuestGUID", NodeType = BinaryContentTypes.Attribute)]
		public DescriptionInt RelatedQuestGUID { get; set; }

	}
}
