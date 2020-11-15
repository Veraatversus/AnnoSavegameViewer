namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class RegionCounterValue {

		[BinaryContent(Name = "Counters", NodeType = BinaryContentTypes.Node)]
		public ValuesNoneCounters Counters { get; set; }

	}
}
