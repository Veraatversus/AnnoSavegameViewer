namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class TradedGoodsValue {

		[BinaryContent(Name = "GoodGuid", NodeType = BinaryContentTypes.Attribute)]
		public HexString GoodGuid { get; set; }

		[BinaryContent(Name = "GoodAmount", NodeType = BinaryContentTypes.Attribute)]
		public HexString GoodAmount { get; set; }

	}
}
