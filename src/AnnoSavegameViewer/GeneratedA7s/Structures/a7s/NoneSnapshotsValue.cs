// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using System;

	public partial class NoneSnapshotsValue {

		[BinaryContent(Name = "CreationTime", NodeType = BinaryContentTypes.Attribute)]
		public TimeSpan CreationTime { get; set; }

		[BinaryContent(Name = "AmountPerPopulation", NodeType = BinaryContentTypes.Node)]
		public NoneAmountPerPopulation AmountPerPopulation { get; set; }

		[BinaryContent(Name = "AmountPerProduct", NodeType = BinaryContentTypes.Node)]
		public NoneAmountPerProduct AmountPerProduct { get; set; }

		[BinaryContent(Name = "GenerationPerProduct", NodeType = BinaryContentTypes.Node)]
		public NoneGenerationPerProduct GenerationPerProduct { get; set; }

		[BinaryContent(Name = "ConsumptionPerProduct", NodeType = BinaryContentTypes.Node)]
		public NoneConsumptionPerProduct ConsumptionPerProduct { get; set; }

	}
}
