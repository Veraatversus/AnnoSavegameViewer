namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class Collectable {

		[BinaryContent(Name = "Collector", NodeType = BinaryContentTypes.Attribute)]
		public HexString Collector { get; set; }

	}
}
