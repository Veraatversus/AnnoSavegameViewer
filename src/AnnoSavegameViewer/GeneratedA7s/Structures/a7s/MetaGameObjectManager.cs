// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using System;

	public partial class MetaGameObjectManager {

		[BinaryContent(Name = "NextMetaGameObjectID", NodeType = BinaryContentTypes.Attribute)]
		public Int64 NextMetaGameObjectID { get; set; }

		[BinaryContent(Name = "MetaObjectMap", NodeType = BinaryContentTypes.Node)]
		public MetaObjectMap MetaObjectMap { get; set; }

	}
}
