// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class PerIncidentDataValue {

		[BinaryContent(Name = "infectionChance", NodeType = BinaryContentTypes.Attribute)]
		public HexString InfectionChance { get; set; }

		[BinaryContent(Name = "infectionChanceDensity", NodeType = BinaryContentTypes.Attribute)]
		public HexString InfectionChanceDensity { get; set; }

		[BinaryContent(Name = "infectionProximity", NodeType = BinaryContentTypes.Node)]
		public InfectionProximity InfectionProximity { get; set; }

		[BinaryContent(Name = "protected", NodeType = BinaryContentTypes.Attribute)]
		public HexString Protected { get; set; }

		[BinaryContent(Name = "factors", NodeType = BinaryContentTypes.Node)]
		public Factors Factors { get; set; }

	}
}
