// Copyright � 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class InfectionChanceTrackerValuesNoneValue {

		[BinaryContent(Name = "Counter", NodeType = BinaryContentTypes.Attribute)]
		public HexString Counter { get; set; }

		[BinaryContent(Name = "AccumulatedInfectionChance", NodeType = BinaryContentTypes.Attribute)]
		public HexString AccumulatedInfectionChance { get; set; }

		[BinaryContent(Name = "HealingUnitSent", NodeType = BinaryContentTypes.Attribute)]
		public HexString HealingUnitSent { get; set; }

	}
}
