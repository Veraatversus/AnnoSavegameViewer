// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class Settlement {

		[BinaryContent(Name = "SettleHandler", NodeType = BinaryContentTypes.Node)]
		public SettleHandler SettleHandler { get; set; }

		[BinaryContent(Name = "LastRateTick", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastRateTick { get; set; }

		[BinaryContent(Name = "IslandCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString IslandCount { get; set; }

		[BinaryContent(Name = "Island", NodeType = BinaryContentTypes.Node)]
		public Island Island { get; set; }

	}
}
