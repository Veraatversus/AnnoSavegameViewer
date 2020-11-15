namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class UnlockDataDataValue {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public UnlockDataDataValuesNoneValue Value { get; set; }

		[BinaryContent(Name = "LockState", NodeType = BinaryContentTypes.Node)]
		public NoneLockState LockState { get; set; }

	}
}
