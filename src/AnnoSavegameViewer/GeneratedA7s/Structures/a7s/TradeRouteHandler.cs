// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class TradeRouteHandler {

		[BinaryContent(Name = "NextShipID", NodeType = BinaryContentTypes.Attribute)]
		public HexString NextShipID { get; set; }

		[BinaryContent(Name = "TradeShips", NodeType = BinaryContentTypes.Node)]
		public TradeShips TradeShips { get; set; }

		[BinaryContent(Name = "TradeRoutes", NodeType = BinaryContentTypes.Node)]
		public TradeRoutes TradeRoutes { get; set; }

		[BinaryContent(Name = "UnassignedTasks", NodeType = BinaryContentTypes.Node)]
		public UnassignedTasks UnassignedTasks { get; set; }

		[BinaryContent(Name = "KilledShipRoutes", NodeType = BinaryContentTypes.Node)]
		public KilledShipRoutes KilledShipRoutes { get; set; }

	}
}
