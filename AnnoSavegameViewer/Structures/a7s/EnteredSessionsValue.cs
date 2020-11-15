namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class EnteredSessionsValue {

		[BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString GUID { get; set; }

		[BinaryContent(Name = "Roles", NodeType = BinaryContentTypes.Attribute)]
		public HexString Roles { get; set; }

		[BinaryContent(Name = "Time", NodeType = BinaryContentTypes.Attribute)]
		public HexString Time { get; set; }

	}
}
