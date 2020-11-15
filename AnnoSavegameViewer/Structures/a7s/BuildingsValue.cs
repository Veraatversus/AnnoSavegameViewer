namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class BuildingsValue {

		[BinaryContent(Name = "harborBlocker", NodeType = BinaryContentTypes.Node)]
		public HarborBlocker HarborBlocker { get; set; }

		[BinaryContent(Name = "Shippaths", NodeType = BinaryContentTypes.Node)]
		public Shippaths Shippaths { get; set; }

		[BinaryContent(Name = "Pos", NodeType = BinaryContentTypes.Attribute)]
		public HexString Pos { get; set; }

		[BinaryContent(Name = "Rotation", NodeType = BinaryContentTypes.Attribute)]
		public HexString Rotation { get; set; }

		[BinaryContent(Name = "ReqSecurity", NodeType = BinaryContentTypes.Attribute)]
		public HexString ReqSecurity { get; set; }

		[BinaryContent(Name = "ReqSecurityBase", NodeType = BinaryContentTypes.Attribute)]
		public HexString ReqSecurityBase { get; set; }

		[BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString GUID { get; set; }

		[BinaryContent(Name = "ProvSecurity", NodeType = BinaryContentTypes.Attribute)]
		public HexString ProvSecurity { get; set; }

	}
}
