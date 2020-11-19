// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class BalanceBeforeBudgets {

		[BinaryContent(Name = "Income", NodeType = BinaryContentTypes.Attribute)]
		public HexString Income { get; set; }

		[BinaryContent(Name = "Expenses", NodeType = BinaryContentTypes.Attribute)]
		public HexString Expenses { get; set; }

	}
}
