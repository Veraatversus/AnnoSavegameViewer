// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class Balance0 {

		[BinaryContent(Name = "CivLevelInfos", NodeType = BinaryContentTypes.Node)]
		public CivLevelInfos CivLevelInfos { get; set; }

		[BinaryContent(Name = "EndProductNeeds", NodeType = BinaryContentTypes.Node)]
		public EndProductNeeds EndProductNeeds { get; set; }

		[BinaryContent(Name = "NonConsumedNeeds", NodeType = BinaryContentTypes.Node)]
		public NonConsumedNeeds NonConsumedNeeds { get; set; }

		[BinaryContent(Name = "AccumulatedNeeds", NodeType = BinaryContentTypes.Node)]
		public AccumulatedNeeds AccumulatedNeeds { get; set; }

		[BinaryContent(Name = "ProductInputs", NodeType = BinaryContentTypes.Node)]
		public ProductInputs ProductInputs { get; set; }

		[BinaryContent(Name = "ProductOutputs", NodeType = BinaryContentTypes.Node)]
		public ProductOutputs ProductOutputs { get; set; }

		[BinaryContent(Name = "ProductDeltasReal", NodeType = BinaryContentTypes.Node)]
		public ProductDeltasReal ProductDeltasReal { get; set; }

		[BinaryContent(Name = "MoneyBalance", NodeType = BinaryContentTypes.Node)]
		public MoneyBalance MoneyBalance { get; set; }

		[BinaryContent(Name = "TaxBalance", NodeType = BinaryContentTypes.Attribute)]
		public HexString TaxBalance { get; set; }

	}
}
