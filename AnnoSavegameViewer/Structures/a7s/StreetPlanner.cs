namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class StreetPlanner {

		[BinaryContent(Name = "StreetUpgradeAreas", NodeType = BinaryContentTypes.Node)]
		public StreetUpgradeAreas StreetUpgradeAreas { get; set; }

		[BinaryContent(Name = "StreetUpgradeTimestamp", NodeType = BinaryContentTypes.Attribute)]
		public HexString StreetUpgradeTimestamp { get; set; }

		[BinaryContent(Name = "Bridges", NodeType = BinaryContentTypes.Node)]
		public Bridges Bridges { get; set; }

	}
}
