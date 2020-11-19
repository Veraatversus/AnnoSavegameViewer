// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class ActiveTradeHandler {

		[BinaryContent(Name = "ships", NodeType = BinaryContentTypes.Node)]
		public ActiveTradeHandlerShips Ships { get; set; }

		[BinaryContent(Name = "lastVisited", NodeType = BinaryContentTypes.Node)]
		public LastVisited LastVisited { get; set; }

		[BinaryContent(Name = "RequestedShips", NodeType = BinaryContentTypes.Node)]
		public RequestedShips RequestedShips { get; set; }

	}
}
