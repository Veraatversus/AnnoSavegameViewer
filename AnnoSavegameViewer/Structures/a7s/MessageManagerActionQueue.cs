namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class MessageManagerActionQueue {

		[BinaryContent(Name = "TimeEventHeap", NodeType = BinaryContentTypes.Node)]
		public ActionQueueTimeEventHeap TimeEventHeap { get; set; }

		[BinaryContent(Name = "IDManager", NodeType = BinaryContentTypes.Node)]
		public MessageManagerActionQueueIDManager IDManager { get; set; }

	}
}
