namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class QueueEntryListValue {

		[BinaryContent(Name = "ShipReference", NodeType = BinaryContentTypes.Node)]
		public ShipReference ShipReference { get; set; }

		[BinaryContent(Name = "QueuePointID", NodeType = BinaryContentTypes.Node)]
		public QueuePointID QueuePointID { get; set; }

		[BinaryContent(Name = "TransportationType", NodeType = BinaryContentTypes.Node)]
		public NoneTransportationType TransportationType { get; set; }

	}
}
