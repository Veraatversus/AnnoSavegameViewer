namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ExpensesValue {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public ExpensesValuesNoneValue Value { get; set; }

	}
}
