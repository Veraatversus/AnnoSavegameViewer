namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;
	using System.Collections.Generic;

	public partial class BalanceCivLevelInfos : ValuesList<BalanceCivLevelInfosValue> {

		[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
		public override List<BalanceCivLevelInfosValue> Values { get; set; }

	}
}
