// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class PassiveTradeHistory {

		[BinaryContent(Name = "PassiveTradeEntries", NodeType = BinaryContentTypes.Node)]
		public PassiveTradeEntries PassiveTradeEntries { get; set; }

		[BinaryContent(Name = "TradeRouteEntries", NodeType = BinaryContentTypes.Node)]
		public TradeRouteEntries TradeRouteEntries { get; set; }

	}
}
