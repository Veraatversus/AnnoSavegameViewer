// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class CounterProposalValue {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public CounterProposalValuesNoneValue Value { get; set; }

		[BinaryContent(Name = "Id", NodeType = BinaryContentTypes.Attribute)]
		public HexString Id { get; set; }

		[BinaryContent(Name = "MinMoney", NodeType = BinaryContentTypes.Attribute)]
		public HexString MinMoney { get; set; }

		[BinaryContent(Name = "MaxMoney", NodeType = BinaryContentTypes.Attribute)]
		public HexString MaxMoney { get; set; }

		[BinaryContent(Name = "CounterProposal", NodeType = BinaryContentTypes.Node)]
		public NoneCounterProposal CounterProposal { get; set; }

	}
}
