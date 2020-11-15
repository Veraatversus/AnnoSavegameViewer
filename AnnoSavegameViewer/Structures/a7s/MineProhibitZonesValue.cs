namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class MineProhibitZonesValue {

		[BinaryContent(Name = "center", NodeType = BinaryContentTypes.Attribute)]
		public HexString Center { get; set; }

		[BinaryContent(Name = "radius", NodeType = BinaryContentTypes.Attribute)]
		public HexString Radius { get; set; }

		[BinaryContent(Name = "area", NodeType = BinaryContentTypes.Attribute)]
		public HexString Area { get; set; }

	}
}
