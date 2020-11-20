// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class WorldManager {

		[BinaryContent(Name = "StreetMap", NodeType = BinaryContentTypes.Node)]
		public StreetMap StreetMap { get; set; }

		[BinaryContent(Name = "RemovedProps", NodeType = BinaryContentTypes.Node)]
		public RemovedProps RemovedProps { get; set; }

		[BinaryContent(Name = "ObjectSpawnerMap", NodeType = BinaryContentTypes.Node)]
		public ObjectSpawnerMap ObjectSpawnerMap { get; set; }

	}
}
