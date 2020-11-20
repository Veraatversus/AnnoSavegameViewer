// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class MessageStatesValue {

		[BinaryContent(Name = "ForbidBefore", NodeType = BinaryContentTypes.Attribute)]
		public HexString ForbidBefore { get; set; }

		[BinaryContent(Name = "Executed", NodeType = BinaryContentTypes.Attribute)]
		public HexString Executed { get; set; }

		[BinaryContent(Name = "TriggerCounts", NodeType = BinaryContentTypes.Attribute)]
		public HexString TriggerCounts { get; set; }

	}
}
