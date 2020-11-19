// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class ProductionLayout {

		[BinaryContent(Name = "BlockCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString BlockCount { get; set; }

		[BinaryContent(Name = "Block", NodeType = BinaryContentTypes.Node)]
		public ProductionLayoutBlock Block { get; set; }

		[BinaryContent(Name = "productionLures", NodeType = BinaryContentTypes.Attribute)]
		public HexString ProductionLures { get; set; }

	}
}
