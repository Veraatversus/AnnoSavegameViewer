namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;
	using System.Collections.Generic;

	public partial class SessionCounterValuesNoneCounters : ValuesList<SessionCounterValuesNoneCountersValue> {

		[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
		public override List<SessionCounterValuesNoneCountersValue> Values { get; set; }

	}
}
