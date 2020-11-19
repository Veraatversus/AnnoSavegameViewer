// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class BalanceCivLevelInfosValue {

		[BinaryContent(Name = "PersonCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString PersonCount { get; set; }

		[BinaryContent(Name = "DefaultBuildingCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString DefaultBuildingCount { get; set; }

		[BinaryContent(Name = "WorkforceAvailable", NodeType = BinaryContentTypes.Attribute)]
		public HexString WorkforceAvailable { get; set; }

		[BinaryContent(Name = "WorkforceConsumed", NodeType = BinaryContentTypes.Attribute)]
		public HexString WorkforceConsumed { get; set; }

	}
}
