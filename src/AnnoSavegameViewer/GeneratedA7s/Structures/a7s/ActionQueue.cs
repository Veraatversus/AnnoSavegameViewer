// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class ActionQueue {

		[BinaryContent(Name = "TimeEventHeap", NodeType = BinaryContentTypes.Node)]
		public TimeEventHeap TimeEventHeap { get; set; }

		[BinaryContent(Name = "IDManager", NodeType = BinaryContentTypes.Node)]
		public ActionQueueIDManager IDManager { get; set; }

	}
}
