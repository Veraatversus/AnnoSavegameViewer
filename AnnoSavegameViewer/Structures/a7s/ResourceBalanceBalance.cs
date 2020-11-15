namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ResourceBalanceBalance {

		[BinaryContent(Name = "CivLevelInfos", NodeType = BinaryContentTypes.Node)]
		public BalanceCivLevelInfos CivLevelInfos { get; set; }

		[BinaryContent(Name = "EndProductNeeds", NodeType = BinaryContentTypes.Node)]
		public BalanceEndProductNeeds EndProductNeeds { get; set; }

		[BinaryContent(Name = "NonConsumedNeeds", NodeType = BinaryContentTypes.Node)]
		public BalanceNonConsumedNeeds NonConsumedNeeds { get; set; }

		[BinaryContent(Name = "AccumulatedNeeds", NodeType = BinaryContentTypes.Node)]
		public BalanceAccumulatedNeeds AccumulatedNeeds { get; set; }

		[BinaryContent(Name = "ProductInputs", NodeType = BinaryContentTypes.Node)]
		public BalanceProductInputs ProductInputs { get; set; }

		[BinaryContent(Name = "ProductOutputs", NodeType = BinaryContentTypes.Node)]
		public BalanceProductOutputs ProductOutputs { get; set; }

		[BinaryContent(Name = "ProductDeltasReal", NodeType = BinaryContentTypes.Node)]
		public BalanceProductDeltasReal ProductDeltasReal { get; set; }

		[BinaryContent(Name = "MoneyBalance", NodeType = BinaryContentTypes.Node)]
		public BalanceMoneyBalance MoneyBalance { get; set; }

		[BinaryContent(Name = "TaxBalance", NodeType = BinaryContentTypes.Attribute)]
		public HexString TaxBalance { get; set; }

	}
}
