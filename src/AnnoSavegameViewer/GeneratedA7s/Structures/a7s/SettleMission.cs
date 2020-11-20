// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class SettleMission {

		[BinaryContent(Name = "AssignedShip", NodeType = BinaryContentTypes.Node)]
		public AssignedShip AssignedShip { get; set; }

		[BinaryContent(Name = "SettleLocation", NodeType = BinaryContentTypes.Node)]
		public SettleLocation SettleLocation { get; set; }

		[BinaryContent(Name = "SettleParams", NodeType = BinaryContentTypes.Node)]
		public SettleParams SettleParams { get; set; }

	}
}
