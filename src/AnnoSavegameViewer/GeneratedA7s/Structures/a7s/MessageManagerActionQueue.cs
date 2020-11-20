// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class MessageManagerActionQueue {

		[BinaryContent(Name = "TimeEventHeap", NodeType = BinaryContentTypes.Node)]
		public ActionQueueTimeEventHeap TimeEventHeap { get; set; }

		[BinaryContent(Name = "IDManager", NodeType = BinaryContentTypes.Node)]
		public MessageManagerActionQueueIDManager IDManager { get; set; }

	}
}
