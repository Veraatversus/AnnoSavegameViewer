// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class SessionTradeRouteManager {

		[BinaryContent(Name = "IDManager", NodeType = BinaryContentTypes.Node)]
		public SessionTradeRouteManagerIDManager IDManager { get; set; }

		[BinaryContent(Name = "RouteMap", NodeType = BinaryContentTypes.Node)]
		public RouteMap RouteMap { get; set; }

	}
}
