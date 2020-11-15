namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class CurrentMinesValue {

		[BinaryContent(Name = "pos", NodeType = BinaryContentTypes.Attribute)]
		public HexString Pos { get; set; }

		[BinaryContent(Name = "area", NodeType = BinaryContentTypes.Attribute)]
		public HexString Area { get; set; }

	}
}
