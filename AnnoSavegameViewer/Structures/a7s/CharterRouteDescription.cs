namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class CharterRouteDescription {

		[BinaryContent(Name = "SourceArea", NodeType = BinaryContentTypes.Attribute)]
		public HexString SourceArea { get; set; }

		[BinaryContent(Name = "TargetArea", NodeType = BinaryContentTypes.Attribute)]
		public HexString TargetArea { get; set; }

	}
}
