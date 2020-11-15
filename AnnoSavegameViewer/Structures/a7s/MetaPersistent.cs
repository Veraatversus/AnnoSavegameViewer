namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class MetaPersistent {

		[BinaryContent(Name = "MetaID", NodeType = BinaryContentTypes.Attribute)]
		public HexString MetaID { get; set; }

	}
}
