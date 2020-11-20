// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class ActionQueueTimeEventHeapData {

		[BinaryContent(Name = "prio", NodeType = BinaryContentTypes.Attribute)]
		public HexString Prio { get; set; }

		[BinaryContent(Name = "element", NodeType = BinaryContentTypes.Node)]
		public DataElement Element { get; set; }

	}
}
