// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class Trader {

		[BinaryContent(Name = "offeredItems", NodeType = BinaryContentTypes.Node)]
		public OfferedItems OfferedItems { get; set; }

		[BinaryContent(Name = "productGain", NodeType = BinaryContentTypes.Node)]
		public ProductGain ProductGain { get; set; }

		[BinaryContent(Name = "nextProductionType", NodeType = BinaryContentTypes.Node)]
		public NextProductionType NextProductionType { get; set; }

		[BinaryContent(Name = "tradeRouteID", NodeType = BinaryContentTypes.Attribute)]
		public Int32 TradeRouteID { get; set; }

		[BinaryContent(Name = "warships", NodeType = BinaryContentTypes.Node)]
		public Warships Warships { get; set; }

		[BinaryContent(Name = "tradeships", NodeType = BinaryContentTypes.Node)]
		public TraderTradeships Tradeships { get; set; }

		[BinaryContent(Name = "sellships", NodeType = BinaryContentTypes.Node)]
		public Sellships Sellships { get; set; }

		[BinaryContent(Name = "sellCooldowns", NodeType = BinaryContentTypes.Attribute)]
		public HexString SellCooldowns { get; set; }

		[BinaryContent(Name = "rerollTimer", NodeType = BinaryContentTypes.Attribute)]
		public TimeSpan RerollTimer { get; set; }

		[BinaryContent(Name = "lastShipProduction", NodeType = BinaryContentTypes.Attribute)]
		public TimeSpan LastShipProduction { get; set; }

		[BinaryContent(Name = "replacementOffers", NodeType = BinaryContentTypes.Node)]
		public ReplacementOffers ReplacementOffers { get; set; }

		[BinaryContent(Name = "currentSellAmount", NodeType = BinaryContentTypes.Attribute)]
		public Int32 CurrentSellAmount { get; set; }

		[BinaryContent(Name = "shipToBuildGUID", NodeType = BinaryContentTypes.Attribute)]
		public DescriptionInt ShipToBuildGUID { get; set; }

		[BinaryContent(Name = "shipBuildTimer", NodeType = BinaryContentTypes.Attribute)]
		public TimeSpan ShipBuildTimer { get; set; }

	}
}
