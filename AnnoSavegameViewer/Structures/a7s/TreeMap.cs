namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class TreeMap {

		[BinaryContent(Name = "x", NodeType = BinaryContentTypes.Attribute)]
		public Int32 X { get; set; }

		[BinaryContent(Name = "y", NodeType = BinaryContentTypes.Attribute)]
		public Int32 Y { get; set; }

		[BinaryContent(Name = "bits", NodeType = BinaryContentTypes.Attribute)]
		public HexString Bits { get; set; }

	}
}
