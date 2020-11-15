namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ActionQueue {

		[BinaryContent(Name = "TimeEventHeap", NodeType = BinaryContentTypes.Node)]
		public TimeEventHeap TimeEventHeap { get; set; }

		[BinaryContent(Name = "IDManager", NodeType = BinaryContentTypes.Node)]
		public ActionQueueIDManager IDManager { get; set; }

	}
}
