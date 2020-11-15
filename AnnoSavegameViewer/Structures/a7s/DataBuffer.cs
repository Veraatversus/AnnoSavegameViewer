namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class DataBuffer {

		[BinaryContent(Name = "sellGoods", NodeType = BinaryContentTypes.Node)]
		public SellGoods SellGoods { get; set; }

		[BinaryContent(Name = "buyGoods", NodeType = BinaryContentTypes.Node)]
		public BuyGoods BuyGoods { get; set; }

		[BinaryContent(Name = "shipPurposes", NodeType = BinaryContentTypes.Node)]
		public ShipPurposes ShipPurposes { get; set; }

	}
}
