namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class GameUniquesValue {

		[BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString GUID { get; set; }

		[BinaryContent(Name = "Type", NodeType = BinaryContentTypes.Node)]
		public NoneType Type { get; set; }

		[BinaryContent(Name = "ObjectID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ObjectID { get; set; }

	}
}
