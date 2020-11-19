// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class VisitorManager {

		[BinaryContent(Name = "AreaVisitorData", NodeType = BinaryContentTypes.Node)]
		public AreaVisitorData AreaVisitorData { get; set; }

		[BinaryContent(Name = "RouteMapping", NodeType = BinaryContentTypes.Node)]
		public RouteMapping RouteMapping { get; set; }

		[BinaryContent(Name = "ReceivedVisitors", NodeType = BinaryContentTypes.Node)]
		public ReceivedVisitors ReceivedVisitors { get; set; }

	}
}
