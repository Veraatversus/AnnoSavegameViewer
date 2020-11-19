// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class CrisisHandler {

		[BinaryContent(Name = "Crises", NodeType = BinaryContentTypes.Node)]
		public Crises Crises { get; set; }

		[BinaryContent(Name = "LastTick", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastTick { get; set; }

	}
}
