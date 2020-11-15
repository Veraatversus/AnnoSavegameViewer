namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class IDManager {

		[BinaryContent(Name = "FreeIDList", NodeType = BinaryContentTypes.Node)]
		public FreeIDList FreeIDList { get; set; }

		[BinaryContent(Name = "NextID", NodeType = BinaryContentTypes.Attribute)]
		public HexString NextID { get; set; }

		[BinaryContent(Name = "HotIDList", NodeType = BinaryContentTypes.Node)]
		public HotIDList HotIDList { get; set; }

	}
}
