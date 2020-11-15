namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;
	using System.Collections.Generic;

	public partial class DecreeUnlockedStates : ValuesList<DecreeUnlockedStatesValue> {

		[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
		public override List<DecreeUnlockedStatesValue> Values { get; set; }

	}
}
