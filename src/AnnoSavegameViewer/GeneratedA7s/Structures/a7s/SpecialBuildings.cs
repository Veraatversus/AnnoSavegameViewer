// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class SpecialBuildings {

		[BinaryContent(Name = "CultureItemCheatTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString CultureItemCheatTime { get; set; }

		[BinaryContent(Name = "NextSpecialBuildingTick", NodeType = BinaryContentTypes.Attribute)]
		public HexString NextSpecialBuildingTick { get; set; }

		[BinaryContent(Name = "MonumentHandler", NodeType = BinaryContentTypes.Node)]
		public MonumentHandler MonumentHandler { get; set; }

	}
}
