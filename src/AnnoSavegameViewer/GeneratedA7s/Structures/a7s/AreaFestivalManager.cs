// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class AreaFestivalManager {

		[BinaryContent(Name = "nextTick", NodeType = BinaryContentTypes.Attribute)]
		public HexString NextTick { get; set; }

		[BinaryContent(Name = "activeType", NodeType = BinaryContentTypes.Node)]
		public ActiveType ActiveType { get; set; }

		[BinaryContent(Name = "activeEffects", NodeType = BinaryContentTypes.Node)]
		public ActiveEffects ActiveEffects { get; set; }

		[BinaryContent(Name = "poolThreshold", NodeType = BinaryContentTypes.Attribute)]
		public HexString PoolThreshold { get; set; }

		[BinaryContent(Name = "poolVal", NodeType = BinaryContentTypes.Attribute)]
		public HexString PoolVal { get; set; }

		[BinaryContent(Name = "isActive", NodeType = BinaryContentTypes.Attribute)]
		public HexString IsActive { get; set; }

		[BinaryContent(Name = "attractivenessBonus", NodeType = BinaryContentTypes.Attribute)]
		public HexString AttractivenessBonus { get; set; }

	}
}
