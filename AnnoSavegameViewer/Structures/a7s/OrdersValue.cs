namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class OrdersValue {

		[BinaryContent(Name = "Type", NodeType = BinaryContentTypes.Attribute)]
		public HexString Type { get; set; }

		[BinaryContent(Name = "ProductGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ProductGUID { get; set; }

		[BinaryContent(Name = "ProductAmount", NodeType = BinaryContentTypes.Attribute)]
		public HexString ProductAmount { get; set; }

	}
}
