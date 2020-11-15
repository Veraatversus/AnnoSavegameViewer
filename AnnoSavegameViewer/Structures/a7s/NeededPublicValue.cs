namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class NeededPublicValue {

		[BinaryContent(Name = "PublicGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString PublicGUID { get; set; }

		[BinaryContent(Name = "Covered", NodeType = BinaryContentTypes.Attribute)]
		public HexString Covered { get; set; }

		[BinaryContent(Name = "Required", NodeType = BinaryContentTypes.Attribute)]
		public HexString Required { get; set; }

		[BinaryContent(Name = "Blocked", NodeType = BinaryContentTypes.Attribute)]
		public HexString Blocked { get; set; }

	}
}
