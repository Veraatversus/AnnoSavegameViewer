namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class Warehouse {

		[BinaryContent(Name = "StorageCapacityRegistered", NodeType = BinaryContentTypes.Attribute)]
		public Int32 StorageCapacityRegistered { get; set; }

		[BinaryContent(Name = "LockedStorage", NodeType = BinaryContentTypes.Node)]
		public LockedStorage LockedStorage { get; set; }

	}
}
