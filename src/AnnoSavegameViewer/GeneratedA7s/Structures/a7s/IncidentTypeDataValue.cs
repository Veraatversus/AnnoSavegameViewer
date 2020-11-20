// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class IncidentTypeDataValue {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public IncidentTypeDataValuesNoneValue Value { get; set; }

		[BinaryContent(Name = "Incidents", NodeType = BinaryContentTypes.Node)]
		public NoneIncidents Incidents { get; set; }

		[BinaryContent(Name = "BuildingInfectionChances", NodeType = BinaryContentTypes.Node)]
		public BuildingInfectionChances BuildingInfectionChances { get; set; }

		[BinaryContent(Name = "Unlocked", NodeType = BinaryContentTypes.Attribute)]
		public HexString Unlocked { get; set; }

		[BinaryContent(Name = "AreaInfectionChance", NodeType = BinaryContentTypes.Attribute)]
		public HexString AreaInfectionChance { get; set; }

	}
}
