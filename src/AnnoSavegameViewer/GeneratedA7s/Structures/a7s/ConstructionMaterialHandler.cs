// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class ConstructionMaterialHandler {

		[BinaryContent(Name = "TransportTasks", NodeType = BinaryContentTypes.Node)]
		public TransportTasks TransportTasks { get; set; }

		[BinaryContent(Name = "UnlockedMaterials", NodeType = BinaryContentTypes.Node)]
		public UnlockedMaterials UnlockedMaterials { get; set; }

		[BinaryContent(Name = "StockLimits", NodeType = BinaryContentTypes.Node)]
		public StockLimits StockLimits { get; set; }

		[BinaryContent(Name = "LastTick", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastTick { get; set; }

	}
}
