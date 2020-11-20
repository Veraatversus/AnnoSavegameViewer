// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using System;

	public partial class EconomyManager {

		[BinaryContent(Name = "MetaStorageCount", NodeType = BinaryContentTypes.Attribute)]
		public Int32 MetaStorageCount { get; set; }

		[BinaryContent(Name = "Pair", NodeType = BinaryContentTypes.Node)]
		public Pair Pair { get; set; }

	}
}
