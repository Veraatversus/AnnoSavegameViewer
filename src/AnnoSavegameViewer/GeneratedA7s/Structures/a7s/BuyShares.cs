// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class BuyShares {

		[BinaryContent(Name = "m_NextCalculationTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString M_NextCalculationTime { get; set; }

		[BinaryContent(Name = "m_IslandPriorities", NodeType = BinaryContentTypes.Node)]
		public M_IslandPriorities M_IslandPriorities { get; set; }

		[BinaryContent(Name = "m_IslandsToOvertake", NodeType = BinaryContentTypes.Attribute)]
		public HexString M_IslandsToOvertake { get; set; }

	}
}
