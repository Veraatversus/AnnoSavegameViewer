namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class PassiveTradeHistory {

		[BinaryContent(Name = "PassiveTradeEntries", NodeType = BinaryContentTypes.Node)]
		public PassiveTradeEntries PassiveTradeEntries { get; set; }

		[BinaryContent(Name = "TradeRouteEntries", NodeType = BinaryContentTypes.Node)]
		public TradeRouteEntries TradeRouteEntries { get; set; }

	}
}
