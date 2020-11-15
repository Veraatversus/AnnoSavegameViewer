namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class NoneDemandedGoodsValue {

		[BinaryContent(Name = "ProductGuid", NodeType = BinaryContentTypes.Attribute)]
		public HexString ProductGuid { get; set; }

		[BinaryContent(Name = "ProductAmount", NodeType = BinaryContentTypes.Attribute)]
		public HexString ProductAmount { get; set; }

		[BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Node)]
		public ValuesNoneQuestID QuestID { get; set; }

	}
}
