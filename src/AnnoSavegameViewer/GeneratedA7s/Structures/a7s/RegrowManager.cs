// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class RegrowManager {

		[BinaryContent(Name = "TreeMap", NodeType = BinaryContentTypes.Node)]
		public TreeMap TreeMap { get; set; }

		[BinaryContent(Name = "CreatedTreeMap", NodeType = BinaryContentTypes.Node)]
		public CreatedTreeMap CreatedTreeMap { get; set; }

		[BinaryContent(Name = "GrowingMap", NodeType = BinaryContentTypes.Node)]
		public GrowingMap GrowingMap { get; set; }

	}
}
