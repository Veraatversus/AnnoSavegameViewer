namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class Id {

		[BinaryContent(Name = "ResolverBuilding", NodeType = BinaryContentTypes.Node)]
		public IdResolverBuilding ResolverBuilding { get; set; }

		[BinaryContent(Name = "Index", NodeType = BinaryContentTypes.Attribute)]
		public HexString Index { get; set; }

	}
}
