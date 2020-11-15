namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class TradeInfosValue {

		[BinaryContent(Name = "Amount", NodeType = BinaryContentTypes.Attribute)]
		public Int32 Amount { get; set; }

		[BinaryContent(Name = "TotalPrice", NodeType = BinaryContentTypes.Attribute)]
		public Int32 TotalPrice { get; set; }

	}
}
