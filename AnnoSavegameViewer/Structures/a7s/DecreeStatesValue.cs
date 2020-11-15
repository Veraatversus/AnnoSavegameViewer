namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;
	using System.Collections.Generic;

	public partial class DecreeStatesValue : ValuesList<DecreeStatesValuesNoneValue> {

		[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
		public override List<DecreeStatesValuesNoneValue> Values { get; set; }

	}
}
