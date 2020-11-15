namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class DynamicObjectGroupCollection {

		[BinaryContent(Name = "ObjectGroups", NodeType = BinaryContentTypes.Node)]
		public ObjectGroups ObjectGroups { get; set; }

	}
}
