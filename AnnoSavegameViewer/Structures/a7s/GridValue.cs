namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class GridValue {

		[BinaryContent(Name = "FreeTiles", NodeType = BinaryContentTypes.Attribute)]
		public HexString FreeTiles { get; set; }

		[BinaryContent(Name = "DistanceToBlocker", NodeType = BinaryContentTypes.Attribute)]
		public HexString DistanceToBlocker { get; set; }

	}
}
