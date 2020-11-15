namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class MiscGrid {

		[BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
		public HexString AreaID { get; set; }

		[BinaryContent(Name = "Origin", NodeType = BinaryContentTypes.Attribute)]
		public HexString Origin { get; set; }

		[BinaryContent(Name = "Max", NodeType = BinaryContentTypes.Attribute)]
		public HexString Max { get; set; }

		[BinaryContent(Name = "Dimensions", NodeType = BinaryContentTypes.Attribute)]
		public HexString Dimensions { get; set; }

		[BinaryContent(Name = "MiscGridData", NodeType = BinaryContentTypes.Attribute)]
		public HexString MiscGridData { get; set; }

	}
}
