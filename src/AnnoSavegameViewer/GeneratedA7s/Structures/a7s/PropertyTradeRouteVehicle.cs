// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class PropertyTradeRouteVehicle {

		[BinaryContent(Name = "RouteStatus", NodeType = BinaryContentTypes.Node)]
		public RouteStatus RouteStatus { get; set; }

		[BinaryContent(Name = "TradeRouteID", NodeType = BinaryContentTypes.Attribute)]
		public Int32 TradeRouteID { get; set; }

		[BinaryContent(Name = "TargetStationID", NodeType = BinaryContentTypes.Attribute)]
		public Int32 TargetStationID { get; set; }

		[BinaryContent(Name = "TargetBuildingID", NodeType = BinaryContentTypes.Attribute)]
		public Int64 TargetBuildingID { get; set; }

		[BinaryContent(Name = "HarbourEvaluated", NodeType = BinaryContentTypes.Attribute)]
		public Boolean HarbourEvaluated { get; set; }

		[BinaryContent(Name = "TargetLoadingHarbour", NodeType = BinaryContentTypes.Attribute)]
		public Int64 TargetLoadingHarbour { get; set; }

		[BinaryContent(Name = "PlannedLoad", NodeType = BinaryContentTypes.Node)]
		public PlannedLoad PlannedLoad { get; set; }

		[BinaryContent(Name = "TradeDescription", NodeType = BinaryContentTypes.Node)]
		public TradeDescription TradeDescription { get; set; }

		[BinaryContent(Name = "WaitingTime", NodeType = BinaryContentTypes.Attribute)]
		public TimeSpan WaitingTime { get; set; }

		[BinaryContent(Name = "ForceUpdateMovement", NodeType = BinaryContentTypes.Attribute)]
		public HexString ForceUpdateMovement { get; set; }

		[BinaryContent(Name = "TradeWaitingTime", NodeType = BinaryContentTypes.Attribute)]
		public TimeSpan TradeWaitingTime { get; set; }

	}
}
