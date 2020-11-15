namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class Rotation {

		[BinaryContent(Name = "Rotation", NodeType = BinaryContentTypes.Attribute)]
		public HexString RotationItem { get; set; }

	}
}
