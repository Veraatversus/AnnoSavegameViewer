// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using System;

	public partial class SlotContainerSlotListValue {

		[BinaryContent(Name = "Stack", NodeType = BinaryContentTypes.Node)]
		public NoneStack Stack { get; set; }

		[BinaryContent(Name = "ProductStackSize", NodeType = BinaryContentTypes.Attribute)]
		public Int32 ProductStackSize { get; set; }

	}
}
