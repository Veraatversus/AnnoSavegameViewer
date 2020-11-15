namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class RandomIslandConfigValue {

		[BinaryContent(Name = "Type", NodeType = BinaryContentTypes.Node)]
		public RandomIslandConfigValueType Type { get; set; }

		[BinaryContent(Name = "Difficulty", NodeType = BinaryContentTypes.Node)]
		public ValueDifficulty Difficulty { get; set; }

	}
}
