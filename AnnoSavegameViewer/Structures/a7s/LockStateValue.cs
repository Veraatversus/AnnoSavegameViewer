namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class LockStateValue {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public LockStateValuesNoneValue Value { get; set; }

	}
}
