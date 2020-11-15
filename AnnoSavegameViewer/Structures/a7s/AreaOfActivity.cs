namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class AreaOfActivity {

		[BinaryContent(Name = "ptCenter", NodeType = BinaryContentTypes.Attribute)]
		public HexString PtCenter { get; set; }

		[BinaryContent(Name = "Radius", NodeType = BinaryContentTypes.Attribute)]
		public HexString Radius { get; set; }

	}
}
