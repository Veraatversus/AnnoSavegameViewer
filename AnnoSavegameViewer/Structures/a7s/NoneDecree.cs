namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class NoneDecree {

		[BinaryContent(Name = "Decree", NodeType = BinaryContentTypes.Attribute)]
		public HexString Decree { get; set; }

	}
}
