// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class MetaResourceHandler {

		[BinaryContent(Name = "SessionMoneyBalance", NodeType = BinaryContentTypes.Node)]
		public SessionMoneyBalance SessionMoneyBalance { get; set; }

		[BinaryContent(Name = "BalanceBeforeBudgets", NodeType = BinaryContentTypes.Node)]
		public BalanceBeforeBudgets BalanceBeforeBudgets { get; set; }

		[BinaryContent(Name = "Budgets", NodeType = BinaryContentTypes.Node)]
		public Budgets Budgets { get; set; }

		[BinaryContent(Name = "LastBudgetTick", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastBudgetTick { get; set; }

		[BinaryContent(Name = "CheatedMoney", NodeType = BinaryContentTypes.Attribute)]
		public HexString CheatedMoney { get; set; }

		[BinaryContent(Name = "CheatedBalance", NodeType = BinaryContentTypes.Attribute)]
		public HexString CheatedBalance { get; set; }

	}
}
