namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class Budget {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public BudgetValue Value { get; set; }

	}
}
