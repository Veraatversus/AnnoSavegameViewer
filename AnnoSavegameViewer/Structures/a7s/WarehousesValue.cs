namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class WarehousesValue {

		[BinaryContent(Name = "ObjectID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ObjectID { get; set; }

		[BinaryContent(Name = "RectWS", NodeType = BinaryContentTypes.Attribute)]
		public HexString RectWS { get; set; }

	}
}
