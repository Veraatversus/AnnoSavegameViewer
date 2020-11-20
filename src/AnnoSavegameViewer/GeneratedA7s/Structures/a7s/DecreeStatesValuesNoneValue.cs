// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class DecreeStatesValuesNoneValue {

		[BinaryContent(Name = "UnlockedState", NodeType = BinaryContentTypes.Attribute)]
		public HexString UnlockedState { get; set; }

		[BinaryContent(Name = "HighlightState", NodeType = BinaryContentTypes.Attribute)]
		public HexString HighlightState { get; set; }

		[BinaryContent(Name = "FirstTimeUnlockAcknowledgedState", NodeType = BinaryContentTypes.Attribute)]
		public HexString FirstTimeUnlockAcknowledgedState { get; set; }

	}
}
