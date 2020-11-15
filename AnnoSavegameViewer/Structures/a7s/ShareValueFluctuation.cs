namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ShareValueFluctuation {

		[BinaryContent(Name = "NextChange", NodeType = BinaryContentTypes.Attribute)]
		public HexString NextChange { get; set; }

		[BinaryContent(Name = "Velocity", NodeType = BinaryContentTypes.Attribute)]
		public HexString Velocity { get; set; }

		[BinaryContent(Name = "Offset", NodeType = BinaryContentTypes.Attribute)]
		public HexString Offset { get; set; }

		[BinaryContent(Name = "Fluctuating", NodeType = BinaryContentTypes.Attribute)]
		public HexString Fluctuating { get; set; }

	}
}
