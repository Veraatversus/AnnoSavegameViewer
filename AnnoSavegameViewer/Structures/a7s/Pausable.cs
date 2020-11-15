namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class Pausable {

		[BinaryContent(Name = "PausedReasons", NodeType = BinaryContentTypes.Attribute)]
		public HexString PausedReasons { get; set; }

	}
}
