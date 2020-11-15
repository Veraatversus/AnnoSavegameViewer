namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class Cost {

		[BinaryContent(Name = "BuildCosts", NodeType = BinaryContentTypes.Node)]
		public BuildCosts BuildCosts { get; set; }

		[BinaryContent(Name = "InfluenceCosts", NodeType = BinaryContentTypes.Node)]
		public InfluenceCosts InfluenceCosts { get; set; }

		[BinaryContent(Name = "RoundUp", NodeType = BinaryContentTypes.Attribute)]
		public HexString RoundUp { get; set; }

	}
}
