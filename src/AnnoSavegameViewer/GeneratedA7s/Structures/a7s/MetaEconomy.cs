// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class MetaEconomy {

		[BinaryContent(Name = "Storage", NodeType = BinaryContentTypes.Node)]
		public Storage Storage { get; set; }

		[BinaryContent(Name = "Transporters", NodeType = BinaryContentTypes.Node)]
		public Transporters Transporters { get; set; }

		[BinaryContent(Name = "MetaEconomyModifiers", NodeType = BinaryContentTypes.Node)]
		public MetaEconomyModifiers MetaEconomyModifiers { get; set; }

		[BinaryContent(Name = "NeedWeightModifierMap", NodeType = BinaryContentTypes.Node)]
		public NeedWeightModifierMap NeedWeightModifierMap { get; set; }

		[BinaryContent(Name = "NeedConsumptionModifierMap", NodeType = BinaryContentTypes.Node)]
		public NeedConsumptionModifierMap NeedConsumptionModifierMap { get; set; }

	}
}
