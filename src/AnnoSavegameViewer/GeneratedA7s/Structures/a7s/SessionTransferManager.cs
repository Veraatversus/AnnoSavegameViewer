// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class SessionTransferManager {

		[BinaryContent(Name = "IDManager", NodeType = BinaryContentTypes.Node)]
		public SessionTransferManagerIDManager IDManager { get; set; }

		[BinaryContent(Name = "QueuedTransfers", NodeType = BinaryContentTypes.Node)]
		public QueuedTransfers QueuedTransfers { get; set; }

	}
}
