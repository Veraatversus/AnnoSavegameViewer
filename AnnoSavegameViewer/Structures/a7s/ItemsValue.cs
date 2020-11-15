namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ItemsValue {

		[BinaryContent(Name = "Amount", NodeType = BinaryContentTypes.Attribute)]
		public HexString Amount { get; set; }

		[BinaryContent(Name = "AssetGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString AssetGUID { get; set; }

	}
}
