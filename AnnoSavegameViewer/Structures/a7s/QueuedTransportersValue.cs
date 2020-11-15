namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class QueuedTransportersValue {

		[BinaryContent(Name = "Transporter", NodeType = BinaryContentTypes.Node)]
		public Transporter Transporter { get; set; }

		[BinaryContent(Name = "ProcessingTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString ProcessingTime { get; set; }

		[BinaryContent(Name = "ProcessingEndTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString ProcessingEndTime { get; set; }

	}
}
