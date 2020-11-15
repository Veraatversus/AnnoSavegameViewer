namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class PathBackground {

		[BinaryContent(Name = "CurrentPath", NodeType = BinaryContentTypes.Attribute)]
		public HexString CurrentPath { get; set; }

	}
}
