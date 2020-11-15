namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class MessageManagerActionQueueIDManager {

		[BinaryContent(Name = "FreeIDList", NodeType = BinaryContentTypes.Node)]
		public MessageManagerActionQueueIDManagerFreeIDList FreeIDList { get; set; }

		[BinaryContent(Name = "NextID", NodeType = BinaryContentTypes.Attribute)]
		public HexString NextID { get; set; }

		[BinaryContent(Name = "HotIDList", NodeType = BinaryContentTypes.Node)]
		public MessageManagerActionQueueIDManagerHotIDList HotIDList { get; set; }

	}
}
