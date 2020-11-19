// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class Cost {

		[BinaryContent(Name = "BuildCosts", NodeType = BinaryContentTypes.Node)]
		public BuildCosts BuildCosts { get; set; }

		[BinaryContent(Name = "InfluenceCosts", NodeType = BinaryContentTypes.Node)]
		public InfluenceCosts InfluenceCosts { get; set; }

		[BinaryContent(Name = "RoundUp", NodeType = BinaryContentTypes.Attribute)]
		public HexString RoundUp { get; set; }

	}
}
