// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class DifficultyThirdParties {

		[BinaryContent(Name = "count", NodeType = BinaryContentTypes.Attribute)]
		public HexString Count { get; set; }

		[BinaryContent(Name = "Profile", NodeType = BinaryContentTypes.Attribute)]
		public HexString Profile { get; set; }

		[BinaryContent(Name = "Difficulty", NodeType = BinaryContentTypes.Node)]
		public DifficultyThirdPartiesDifficulty Difficulty { get; set; }

	}
}
