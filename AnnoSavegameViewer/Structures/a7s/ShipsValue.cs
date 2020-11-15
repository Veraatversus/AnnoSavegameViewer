namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ShipsValue {

		[BinaryContent(Name = "Timestamp", NodeType = BinaryContentTypes.Attribute)]
		public HexString Timestamp { get; set; }

		[BinaryContent(Name = "Purpose", NodeType = BinaryContentTypes.Node)]
		public Purpose Purpose { get; set; }

		[BinaryContent(Name = "UsingSession", NodeType = BinaryContentTypes.Attribute)]
		public HexString UsingSession { get; set; }

		[BinaryContent(Name = "Ship", NodeType = BinaryContentTypes.Attribute)]
		public HexString Ship { get; set; }

		[BinaryContent(Name = "ShipGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ShipGUID { get; set; }

	}
}
