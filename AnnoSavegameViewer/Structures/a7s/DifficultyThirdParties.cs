namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class DifficultyThirdParties {

		[BinaryContent(Name = "count", NodeType = BinaryContentTypes.Attribute)]
		public HexString Count { get; set; }

		[BinaryContent(Name = "Profile", NodeType = BinaryContentTypes.Attribute)]
		public HexString Profile { get; set; }

		[BinaryContent(Name = "Difficulty", NodeType = BinaryContentTypes.Node)]
		public DifficultyThirdPartiesDifficulty Difficulty { get; set; }

	}
}
