namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class TradeRoute {

		[BinaryContent(Name = "NextShipID", NodeType = BinaryContentTypes.Attribute)]
		public HexString NextShipID { get; set; }

		[BinaryContent(Name = "TradeShips", NodeType = BinaryContentTypes.Node)]
		public TradeRouteTradeShips TradeShips { get; set; }

		[BinaryContent(Name = "TradeRoutes", NodeType = BinaryContentTypes.Node)]
		public TradeRouteTradeRoutes TradeRoutes { get; set; }

		[BinaryContent(Name = "UnassignedTasks", NodeType = BinaryContentTypes.Node)]
		public TradeRouteUnassignedTasks UnassignedTasks { get; set; }

		[BinaryContent(Name = "KilledShipRoutes", NodeType = BinaryContentTypes.Node)]
		public TradeRouteKilledShipRoutes KilledShipRoutes { get; set; }

	}
}
