namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class SessionMoneyBalanceValue {

		[BinaryContent(Name = "Income", NodeType = BinaryContentTypes.Attribute)]
		public HexString Income { get; set; }

		[BinaryContent(Name = "Expenses", NodeType = BinaryContentTypes.Node)]
		public Expenses Expenses { get; set; }

	}
}
