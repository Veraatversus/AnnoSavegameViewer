namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class SnapshotsValue {

		[BinaryContent(Name = "CreationTime", NodeType = BinaryContentTypes.Attribute)]
		public TimeSpan CreationTime { get; set; }

		[BinaryContent(Name = "AmountPerPopulation", NodeType = BinaryContentTypes.Node)]
		public AmountPerPopulation AmountPerPopulation { get; set; }

		[BinaryContent(Name = "AmountPerProduct", NodeType = BinaryContentTypes.Node)]
		public AmountPerProduct AmountPerProduct { get; set; }

		[BinaryContent(Name = "GenerationPerProduct", NodeType = BinaryContentTypes.Node)]
		public GenerationPerProduct GenerationPerProduct { get; set; }

		[BinaryContent(Name = "ConsumptionPerProduct", NodeType = BinaryContentTypes.Node)]
		public ConsumptionPerProduct ConsumptionPerProduct { get; set; }

	}
}
