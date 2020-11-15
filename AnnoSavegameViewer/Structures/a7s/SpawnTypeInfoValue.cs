namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class SpawnTypeInfoValue {

		[BinaryContent(Name = "SpawnObjectCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString SpawnObjectCount { get; set; }

		[BinaryContent(Name = "SpawnedObjectIDs", NodeType = BinaryContentTypes.Attribute)]
		public HexString SpawnedObjectIDs { get; set; }

	}
}
