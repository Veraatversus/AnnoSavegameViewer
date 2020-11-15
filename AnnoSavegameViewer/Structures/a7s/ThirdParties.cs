namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ThirdParties {

		[BinaryContent(Name = "count", NodeType = BinaryContentTypes.Attribute)]
		public Int64 Count { get; set; }

		[BinaryContent(Name = "Profile", NodeType = BinaryContentTypes.Attribute)]
		public DescriptionInt Profile { get; set; }

		[BinaryContent(Name = "Difficulty", NodeType = BinaryContentTypes.Node)]
		public ThirdPartiesDifficulty Difficulty { get; set; }

	}
}
