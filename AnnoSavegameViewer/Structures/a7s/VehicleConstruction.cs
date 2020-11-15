namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class VehicleConstruction {

		[BinaryContent(Name = "PendingCraftables", NodeType = BinaryContentTypes.Node)]
		public PendingCraftables PendingCraftables { get; set; }

		[BinaryContent(Name = "UnlockedTradeShips", NodeType = BinaryContentTypes.Attribute)]
		public HexString UnlockedTradeShips { get; set; }

	}
}
