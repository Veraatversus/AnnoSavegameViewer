namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ObjectsValue {

		[BinaryContent(Name = "ObjectID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ObjectID { get; set; }

		[BinaryContent(Name = "Type", NodeType = BinaryContentTypes.Attribute)]
		public HexString Type { get; set; }

		[BinaryContent(Name = "CargoItems", NodeType = BinaryContentTypes.Node)]
		public CargoItems CargoItems { get; set; }

	}
}
