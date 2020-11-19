// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class PriorityHandler {

		[BinaryContent(Name = "Prios", NodeType = BinaryContentTypes.Node)]
		public Prios Prios { get; set; }

		[BinaryContent(Name = "ProductionCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString ProductionCount { get; set; }

	}
}
