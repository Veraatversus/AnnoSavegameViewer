// Copyright � 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using System;

	public partial class AreaSlotContainer {

		[BinaryContent(Name = "SlotList", NodeType = BinaryContentTypes.Node)]
		public AreaSlotContainerSlotList SlotList { get; set; }

		[BinaryContent(Name = "UnlimitedSlotCount", NodeType = BinaryContentTypes.Attribute)]
		public Boolean UnlimitedSlotCount { get; set; }

		[BinaryContent(Name = "UnlimitedStack", NodeType = BinaryContentTypes.Attribute)]
		public Boolean UnlimitedStack { get; set; }

		[BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
		public Int16 AreaID { get; set; }

	}
}
