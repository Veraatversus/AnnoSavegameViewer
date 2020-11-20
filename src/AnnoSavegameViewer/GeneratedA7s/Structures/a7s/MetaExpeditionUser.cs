// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class MetaExpeditionUser {

		[BinaryContent(Name = "expeditions", NodeType = BinaryContentTypes.Node)]
		public Expeditions Expeditions { get; set; }

		[BinaryContent(Name = "expeditionSlots", NodeType = BinaryContentTypes.Node)]
		public ExpeditionSlots ExpeditionSlots { get; set; }

		[BinaryContent(Name = "nextExpeditionSlotTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString NextExpeditionSlotTime { get; set; }

		[BinaryContent(Name = "expeditionOverviewEntered", NodeType = BinaryContentTypes.Attribute)]
		public HexString ExpeditionOverviewEntered { get; set; }

	}
}
