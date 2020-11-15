namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ReceivedPermissionInfo {

		[BinaryContent(Name = "LastChange", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastChange { get; set; }

	}
}
