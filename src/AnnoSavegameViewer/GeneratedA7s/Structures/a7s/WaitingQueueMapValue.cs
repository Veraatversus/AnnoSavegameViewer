// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class WaitingQueueMapValue {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public WaitingQueueMapValuesNoneValue Value { get; set; }

		[BinaryContent(Name = "Layer", NodeType = BinaryContentTypes.Node)]
		public Layer Layer { get; set; }

		[BinaryContent(Name = "QueueEntryList", NodeType = BinaryContentTypes.Node)]
		public QueueEntryList QueueEntryList { get; set; }

		[BinaryContent(Name = "EllipsisDimensions", NodeType = BinaryContentTypes.Attribute)]
		public HexString EllipsisDimensions { get; set; }

		[BinaryContent(Name = "WaitingRowArray", NodeType = BinaryContentTypes.Node)]
		public WaitingRowArray WaitingRowArray { get; set; }

	}
}
