namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class BudgetsValue {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public BudgetsValuesNoneValue Value { get; set; }

		[BinaryContent(Name = "IncomeShare", NodeType = BinaryContentTypes.Attribute)]
		public HexString IncomeShare { get; set; }

		[BinaryContent(Name = "AvailableMoney", NodeType = BinaryContentTypes.Attribute)]
		public HexString AvailableMoney { get; set; }

		[BinaryContent(Name = "Costs", NodeType = BinaryContentTypes.Attribute)]
		public HexString Costs { get; set; }

		[BinaryContent(Name = "Income", NodeType = BinaryContentTypes.Attribute)]
		public HexString Income { get; set; }

		[BinaryContent(Name = "Limit", NodeType = BinaryContentTypes.Attribute)]
		public HexString Limit { get; set; }

	}
}
