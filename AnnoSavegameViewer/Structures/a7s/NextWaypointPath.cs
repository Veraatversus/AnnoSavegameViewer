namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class NextWaypointPath {

		[BinaryContent(Name = "Path", NodeType = BinaryContentTypes.Attribute)]
		public HexString Path { get; set; }

		[BinaryContent(Name = "AverageSpeed", NodeType = BinaryContentTypes.Attribute)]
		public HexString AverageSpeed { get; set; }

	}
}
