namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class SessionTransferManager {

		[BinaryContent(Name = "IDManager", NodeType = BinaryContentTypes.Node)]
		public SessionTransferManagerIDManager IDManager { get; set; }

		[BinaryContent(Name = "QueuedTransfers", NodeType = BinaryContentTypes.Node)]
		public QueuedTransfers QueuedTransfers { get; set; }

	}
}
