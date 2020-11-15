namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;
	using System.Collections.Generic;

	public partial class EventRewards2 : ValuesList<EventRewards2Value> {

		[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
		public override List<EventRewards2Value> Values { get; set; }

	}
}
