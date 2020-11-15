namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ProductionLayout {

		[BinaryContent(Name = "BlockCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString BlockCount { get; set; }

		[BinaryContent(Name = "Block", NodeType = BinaryContentTypes.Node)]
		public ProductionLayoutBlock Block { get; set; }

		[BinaryContent(Name = "productionLures", NodeType = BinaryContentTypes.Attribute)]
		public HexString ProductionLures { get; set; }

	}
}
