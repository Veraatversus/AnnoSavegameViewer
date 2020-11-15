namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class VisitorManager {

		[BinaryContent(Name = "AreaVisitorData", NodeType = BinaryContentTypes.Node)]
		public AreaVisitorData AreaVisitorData { get; set; }

		[BinaryContent(Name = "RouteMapping", NodeType = BinaryContentTypes.Node)]
		public RouteMapping RouteMapping { get; set; }

		[BinaryContent(Name = "ReceivedVisitors", NodeType = BinaryContentTypes.Node)]
		public ReceivedVisitors ReceivedVisitors { get; set; }

	}
}
