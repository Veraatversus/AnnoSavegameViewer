namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class NoneInteraction {

		[BinaryContent(Name = "Callback", NodeType = BinaryContentTypes.Attribute)]
		public HexString Callback { get; set; }

	}
}
