namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ObjectGroupsValue {

		[BinaryContent(Name = "GameObjects", NodeType = BinaryContentTypes.Node)]
		public GameObjects GameObjects { get; set; }

	}
}
