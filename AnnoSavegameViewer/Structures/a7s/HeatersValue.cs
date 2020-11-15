namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class HeatersValue {

		[BinaryContent(Name = "IsCity", NodeType = BinaryContentTypes.Attribute)]
		public HexString IsCity { get; set; }

		[BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ID { get; set; }

		[BinaryContent(Name = "Center", NodeType = BinaryContentTypes.Attribute)]
		public HexString Center { get; set; }

		[BinaryContent(Name = "Rect", NodeType = BinaryContentTypes.Attribute)]
		public HexString Rect { get; set; }

	}
}
