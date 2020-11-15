namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class FOWGrid {

		[BinaryContent(Name = "Width", NodeType = BinaryContentTypes.Attribute)]
		public HexString Width { get; set; }

		[BinaryContent(Name = "Height", NodeType = BinaryContentTypes.Attribute)]
		public HexString Height { get; set; }

		[BinaryContent(Name = "bits", NodeType = BinaryContentTypes.Attribute)]
		public HexString Bits { get; set; }

	}
}
