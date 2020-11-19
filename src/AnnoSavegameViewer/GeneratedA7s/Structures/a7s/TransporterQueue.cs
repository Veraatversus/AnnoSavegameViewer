// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class TransporterQueue {

		[BinaryContent(Name = "QueuedTransporters", NodeType = BinaryContentTypes.Node)]
		public QueuedTransporters QueuedTransporters { get; set; }

		[BinaryContent(Name = "ProcessingTransporters", NodeType = BinaryContentTypes.Node)]
		public ProcessingTransporters ProcessingTransporters { get; set; }

	}
}
