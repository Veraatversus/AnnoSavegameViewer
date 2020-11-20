// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class GameObjectManager {

		[BinaryContent(Name = "GameObjectLabelMap", NodeType = BinaryContentTypes.Node)]
		public GameObjectLabelMap GameObjectLabelMap { get; set; }

		[BinaryContent(Name = "DynamicObjectGroupCollection", NodeType = BinaryContentTypes.Node)]
		public DynamicObjectGroupCollection DynamicObjectGroupCollection { get; set; }

	}
}
