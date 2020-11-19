// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class PassiveTrade {

		[BinaryContent(Name = "OfferMap", NodeType = BinaryContentTypes.Node)]
		public OfferMap OfferMap { get; set; }

		[BinaryContent(Name = "History", NodeType = BinaryContentTypes.Node)]
		public PassiveTradeHistory History { get; set; }

		[BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
		public HexString AreaID { get; set; }

		[BinaryContent(Name = "MinimumStock", NodeType = BinaryContentTypes.Node)]
		public MinimumStock MinimumStock { get; set; }

		[BinaryContent(Name = "BuysAllItems", NodeType = BinaryContentTypes.Attribute)]
		public HexString BuysAllItems { get; set; }

		[BinaryContent(Name = "BuysAllGoods", NodeType = BinaryContentTypes.Attribute)]
		public HexString BuysAllGoods { get; set; }

	}
}
