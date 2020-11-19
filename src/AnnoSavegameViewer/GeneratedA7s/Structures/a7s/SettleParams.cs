// Copyright � 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class SettleParams {

		[BinaryContent(Name = "ForceArea", NodeType = BinaryContentTypes.Attribute)]
		public HexString ForceArea { get; set; }

		[BinaryContent(Name = "RecommendedPosition", NodeType = BinaryContentTypes.Node)]
		public RecommendedPosition RecommendedPosition { get; set; }

		[BinaryContent(Name = "SettleMissionType", NodeType = BinaryContentTypes.Node)]
		public SettleMissionType SettleMissionType { get; set; }

	}
}
