namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class RouteWaypointsValue {

		[BinaryContent(Name = "Area", NodeType = BinaryContentTypes.Attribute)]
		public HexString Area { get; set; }

		[BinaryContent(Name = "Time", NodeType = BinaryContentTypes.Attribute)]
		public HexString Time { get; set; }

		[BinaryContent(Name = "HarborPosition", NodeType = BinaryContentTypes.Attribute)]
		public HexString HarborPosition { get; set; }

		[BinaryContent(Name = "DurationMap", NodeType = BinaryContentTypes.Node)]
		public DurationMap DurationMap { get; set; }

	}
}
