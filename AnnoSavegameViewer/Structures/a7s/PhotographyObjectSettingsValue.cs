namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class PhotographyObjectSettingsValue {

		[BinaryContent(Name = "ObjectSettings", NodeType = BinaryContentTypes.Attribute)]
		public HexString ObjectSettings { get; set; }

		[BinaryContent(Name = "CircleAreaPercentage", NodeType = BinaryContentTypes.Attribute)]
		public HexString CircleAreaPercentage { get; set; }

		[BinaryContent(Name = "LinkedNewspaperArticle", NodeType = BinaryContentTypes.Attribute)]
		public HexString LinkedNewspaperArticle { get; set; }

	}
}
