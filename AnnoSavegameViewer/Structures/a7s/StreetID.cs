namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class StreetID {

		[BinaryContent(Name = "x", NodeType = BinaryContentTypes.Attribute)]
		public Int32 X { get; set; }

		[BinaryContent(Name = "y", NodeType = BinaryContentTypes.Attribute)]
		public Int32 Y { get; set; }

		[BinaryContent(Name = "val", NodeType = BinaryContentTypes.Attribute)]
		public HexString Val { get; set; }

	}
}
