namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class BuildingsByIDValue {

		[BinaryContent(Name = "ObjectID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ObjectID { get; set; }

		[BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString GUID { get; set; }

		[BinaryContent(Name = "CenterPos", NodeType = BinaryContentTypes.Attribute)]
		public HexString CenterPos { get; set; }

		[BinaryContent(Name = "Rotation", NodeType = BinaryContentTypes.Attribute)]
		public HexString Rotation { get; set; }

		[BinaryContent(Name = "Variation", NodeType = BinaryContentTypes.Attribute)]
		public HexString Variation { get; set; }

	}
}
