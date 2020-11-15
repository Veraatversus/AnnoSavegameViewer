namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class EconomyManager {

		[BinaryContent(Name = "MetaStorageCount", NodeType = BinaryContentTypes.Attribute)]
		public Int32 MetaStorageCount { get; set; }

		[BinaryContent(Name = "Pair", NodeType = BinaryContentTypes.Node)]
		public Pair Pair { get; set; }

	}
}
