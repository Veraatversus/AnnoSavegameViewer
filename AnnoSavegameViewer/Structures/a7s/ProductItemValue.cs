namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ProductItemValue {

		[BinaryContent(Name = "ItemID", NodeType = BinaryContentTypes.Attribute)]
		public Int64 ItemID { get; set; }

		[BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
		public DescriptionInt GUID { get; set; }

	}
}
