namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class NodesValue {

		[BinaryContent(Name = "Position", NodeType = BinaryContentTypes.Attribute)]
		public Point2D<Int32> Position { get; set; }

		[BinaryContent(Name = "IsPersistent", NodeType = BinaryContentTypes.Attribute)]
		public Boolean IsPersistent { get; set; }

	}
}
