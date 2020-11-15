namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class GameSetupDifficulty {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public GameSetupDifficultyValue Value { get; set; }

	}
}
