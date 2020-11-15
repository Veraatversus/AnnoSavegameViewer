namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class MetaUnlockManager {

		[BinaryContent(Name = "LockState", NodeType = BinaryContentTypes.Node)]
		public LockState LockState { get; set; }

	}
}
