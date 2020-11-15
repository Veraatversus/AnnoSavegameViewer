namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class GroupHandler {

		[BinaryContent(Name = "NextGroupID", NodeType = BinaryContentTypes.Attribute)]
		public Int16 NextGroupID { get; set; }

		[BinaryContent(Name = "Groups", NodeType = BinaryContentTypes.Node)]
		public Groups Groups { get; set; }

	}
}
