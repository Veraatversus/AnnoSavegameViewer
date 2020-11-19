// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class AreaObjectManager {

		[BinaryContent(Name = "GameObjectIDCounter", NodeType = BinaryContentTypes.Attribute)]
		public Int64 GameObjectIDCounter { get; set; }

		[BinaryContent(Name = "NonGameObjectIDCounter", NodeType = BinaryContentTypes.Attribute)]
		public Int64 NonGameObjectIDCounter { get; set; }

		[BinaryContent(Name = "QueuedChangeGUID", NodeType = BinaryContentTypes.Node)]
		public QueuedChangeGUID QueuedChangeGUID { get; set; }

		[BinaryContent(Name = "QueuedDeletes", NodeType = BinaryContentTypes.Attribute)]
		public HexString QueuedDeletes { get; set; }

		[BinaryContent(Name = "ObjectGroupFilterCollection", NodeType = BinaryContentTypes.Node)]
		public ObjectGroupFilterCollection ObjectGroupFilterCollection { get; set; }

		[BinaryContent(Name = "ObjectGroupCollection", NodeType = BinaryContentTypes.Node)]
		public ObjectGroupCollection ObjectGroupCollection { get; set; }

		[BinaryContent(Name = "GameObject", NodeType = BinaryContentTypes.Node)]
		public GameObject GameObject { get; set; }

		[BinaryContent(Name = "Nature", NodeType = BinaryContentTypes.Node)]
		public Nature Nature { get; set; }

	}
}
