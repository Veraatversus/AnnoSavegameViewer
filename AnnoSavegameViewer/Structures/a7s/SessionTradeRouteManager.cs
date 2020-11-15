namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class SessionTradeRouteManager {

		[BinaryContent(Name = "IDManager", NodeType = BinaryContentTypes.Node)]
		public SessionTradeRouteManagerIDManager IDManager { get; set; }

		[BinaryContent(Name = "RouteMap", NodeType = BinaryContentTypes.Node)]
		public RouteMap RouteMap { get; set; }

	}
}
