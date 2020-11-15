namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;
	using System.Collections.Generic;

	public partial class Conditions : ValuesList<ConditionsValue> {

		[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
		public override List<ConditionsValue> Values { get; set; }

	}
}
