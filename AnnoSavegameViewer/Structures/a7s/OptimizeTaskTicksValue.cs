namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class OptimizeTaskTicksValue {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public OptimizeTaskTicksValuesNoneValue Value { get; set; }

		[BinaryContent(Name = "LastTrigger", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastTrigger { get; set; }

		[BinaryContent(Name = "BuildCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString BuildCount { get; set; }

	}
}
