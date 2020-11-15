namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class SessionTransferManagerIDManager {

		[BinaryContent(Name = "FreeIDList", NodeType = BinaryContentTypes.Node)]
		public IDManagerFreeIDList FreeIDList { get; set; }

		[BinaryContent(Name = "NextID", NodeType = BinaryContentTypes.Attribute)]
		public HexString NextID { get; set; }

		[BinaryContent(Name = "HotIDList", NodeType = BinaryContentTypes.Node)]
		public IDManagerHotIDList HotIDList { get; set; }

	}
}
