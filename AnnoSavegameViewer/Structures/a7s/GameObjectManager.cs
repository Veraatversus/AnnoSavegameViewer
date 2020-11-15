namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class GameObjectManager {

		[BinaryContent(Name = "GameObjectLabelMap", NodeType = BinaryContentTypes.Node)]
		public GameObjectLabelMap GameObjectLabelMap { get; set; }

		[BinaryContent(Name = "DynamicObjectGroupCollection", NodeType = BinaryContentTypes.Node)]
		public DynamicObjectGroupCollection DynamicObjectGroupCollection { get; set; }

	}
}
