namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class NoneQuestMetaData {

		[BinaryContent(Name = "QuestArea", NodeType = BinaryContentTypes.Attribute)]
		public HexString QuestArea { get; set; }

	}
}
