namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class TransporterQueue {

		[BinaryContent(Name = "QueuedTransporters", NodeType = BinaryContentTypes.Node)]
		public QueuedTransporters QueuedTransporters { get; set; }

		[BinaryContent(Name = "ProcessingTransporters", NodeType = BinaryContentTypes.Node)]
		public ProcessingTransporters ProcessingTransporters { get; set; }

	}
}
