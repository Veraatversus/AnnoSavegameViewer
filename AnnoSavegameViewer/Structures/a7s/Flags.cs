namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class Flags {

		[BinaryContent(Name = "flags", NodeType = BinaryContentTypes.Attribute)]
		public HexString FlagsItem { get; set; }

	}
}
