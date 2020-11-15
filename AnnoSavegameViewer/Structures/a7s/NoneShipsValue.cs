namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class NoneShipsValue {

		[BinaryContent(Name = "ShipObject", NodeType = BinaryContentTypes.Attribute)]
		public HexString ShipObject { get; set; }

		[BinaryContent(Name = "CurrentArea", NodeType = BinaryContentTypes.Attribute)]
		public HexString CurrentArea { get; set; }

		[BinaryContent(Name = "DestinationArea", NodeType = BinaryContentTypes.Attribute)]
		public HexString DestinationArea { get; set; }

		[BinaryContent(Name = "ShipState", NodeType = BinaryContentTypes.Node)]
		public ShipState ShipState { get; set; }

		[BinaryContent(Name = "Route", NodeType = BinaryContentTypes.Attribute)]
		public HexString Route { get; set; }

	}
}
