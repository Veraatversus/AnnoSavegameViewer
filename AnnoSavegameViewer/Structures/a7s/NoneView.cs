namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class NoneView {

		[BinaryContent(Name = "From", NodeType = BinaryContentTypes.Attribute)]
		public HexString From { get; set; }

		[BinaryContent(Name = "At", NodeType = BinaryContentTypes.Attribute)]
		public HexString At { get; set; }

		[BinaryContent(Name = "Up", NodeType = BinaryContentTypes.Attribute)]
		public HexString Up { get; set; }

		[BinaryContent(Name = "Direction", NodeType = BinaryContentTypes.Attribute)]
		public HexString Direction { get; set; }

	}
}
