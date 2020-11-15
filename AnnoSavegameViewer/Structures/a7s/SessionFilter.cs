namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class SessionFilter {

		[BinaryContent(Name = "SessionGUIDs", NodeType = BinaryContentTypes.Attribute)]
		public HexString SessionGUIDs { get; set; }

	}
}
