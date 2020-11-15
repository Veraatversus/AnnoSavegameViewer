namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class EstimatedConstructionGoodsValue {

		[BinaryContent(Name = "Product", NodeType = BinaryContentTypes.Attribute)]
		public HexString Product { get; set; }

		[BinaryContent(Name = "Count", NodeType = BinaryContentTypes.Attribute)]
		public HexString Count { get; set; }

	}
}
