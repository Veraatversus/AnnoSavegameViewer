namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class Bridge {

		[BinaryContent(Name = "Path", NodeType = BinaryContentTypes.Node)]
		public Path Path { get; set; }

		[BinaryContent(Name = "BezierPath", NodeType = BinaryContentTypes.Node)]
		public BridgeBezierPath BezierPath { get; set; }

	}
}
