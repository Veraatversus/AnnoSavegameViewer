// Copyright � 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class LastRewardContainer {

		[BinaryContent(Name = "SlotList", NodeType = BinaryContentTypes.Node)]
		public SlotList SlotList { get; set; }

		[BinaryContent(Name = "UnlimitedSlotCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString UnlimitedSlotCount { get; set; }

		[BinaryContent(Name = "UnlimitedStack", NodeType = BinaryContentTypes.Attribute)]
		public HexString UnlimitedStack { get; set; }

		[BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
		public HexString AreaID { get; set; }

	}
}
