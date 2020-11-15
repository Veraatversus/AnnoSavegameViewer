namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ActionQueueTimeEventHeap {

		[BinaryContent(Name = "lastElement", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastElement { get; set; }

		[BinaryContent(Name = "data", NodeType = BinaryContentTypes.Node)]
		public ActionQueueTimeEventHeapData Data { get; set; }

	}
}
