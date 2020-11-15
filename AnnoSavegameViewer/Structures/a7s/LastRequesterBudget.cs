namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class LastRequesterBudget {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public LastRequesterBudgetValue Value { get; set; }

	}
}
