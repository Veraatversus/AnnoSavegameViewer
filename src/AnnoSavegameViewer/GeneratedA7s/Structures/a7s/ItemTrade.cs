// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class ItemTrade {

		[BinaryContent(Name = "Items", NodeType = BinaryContentTypes.Node)]
		public Items Items { get; set; }

		[BinaryContent(Name = "LastReroll", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastReroll { get; set; }

	}
}
