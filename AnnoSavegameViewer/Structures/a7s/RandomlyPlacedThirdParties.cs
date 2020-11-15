namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;
	using System.Collections.Generic;

	public partial class RandomlyPlacedThirdParties : ValuesList<RandomlyPlacedThirdPartiesValue> {

		[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
		public override List<RandomlyPlacedThirdPartiesValue> Values { get; set; }

	}
}
