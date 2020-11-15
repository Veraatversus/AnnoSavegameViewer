namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class NoneSignsAndFeedbackSettings {

		[BinaryContent(Name = "MinimapToken", NodeType = BinaryContentTypes.Attribute)]
		public HexString MinimapToken { get; set; }

		[BinaryContent(Name = "Infolayer", NodeType = BinaryContentTypes.Attribute)]
		public HexString Infolayer { get; set; }

	}
}
