// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class Districts {

		[BinaryContent(Name = "SlotPositions", NodeType = BinaryContentTypes.Node)]
		public SlotPositions SlotPositions { get; set; }

		[BinaryContent(Name = "VirtualSlots", NodeType = BinaryContentTypes.Node)]
		public VirtualSlots VirtualSlots { get; set; }

		[BinaryContent(Name = "Warehouses", NodeType = BinaryContentTypes.Node)]
		public Warehouses Warehouses { get; set; }

		[BinaryContent(Name = "ReservedCellKontor", NodeType = BinaryContentTypes.Attribute)]
		public HexString ReservedCellKontor { get; set; }

		[BinaryContent(Name = "ReservedCellCityCore", NodeType = BinaryContentTypes.Attribute)]
		public HexString ReservedCellCityCore { get; set; }

		[BinaryContent(Name = "RecommendedCityRect", NodeType = BinaryContentTypes.Attribute)]
		public HexString RecommendedCityRect { get; set; }

	}
}
