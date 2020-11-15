namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class TradeShipsValue {

		[BinaryContent(Name = "ObjID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ObjID { get; set; }

		[BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ID { get; set; }

		[BinaryContent(Name = "OnRoute", NodeType = BinaryContentTypes.Attribute)]
		public HexString OnRoute { get; set; }

		[BinaryContent(Name = "SlotCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString SlotCount { get; set; }

		[BinaryContent(Name = "StackSize", NodeType = BinaryContentTypes.Attribute)]
		public HexString StackSize { get; set; }

		[BinaryContent(Name = "Speed", NodeType = BinaryContentTypes.Attribute)]
		public HexString Speed { get; set; }

		[BinaryContent(Name = "TransportType", NodeType = BinaryContentTypes.Node)]
		public TransportType TransportType { get; set; }

	}
}
