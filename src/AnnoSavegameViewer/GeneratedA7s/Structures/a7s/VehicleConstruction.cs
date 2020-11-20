// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class VehicleConstruction {

		[BinaryContent(Name = "PendingCraftables", NodeType = BinaryContentTypes.Node)]
		public PendingCraftables PendingCraftables { get; set; }

		[BinaryContent(Name = "UnlockedTradeShips", NodeType = BinaryContentTypes.Attribute)]
		public HexString UnlockedTradeShips { get; set; }

	}
}
