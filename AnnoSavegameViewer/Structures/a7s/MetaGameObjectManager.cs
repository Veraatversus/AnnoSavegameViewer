namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class MetaGameObjectManager {

		[BinaryContent(Name = "NextMetaGameObjectID", NodeType = BinaryContentTypes.Attribute)]
		public Int64 NextMetaGameObjectID { get; set; }

		[BinaryContent(Name = "MetaObjectMap", NodeType = BinaryContentTypes.Node)]
		public MetaObjectMap MetaObjectMap { get; set; }

	}
}
