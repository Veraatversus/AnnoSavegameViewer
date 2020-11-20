// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class ParticipantsWinLoseDataValue {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public ParticipantsWinLoseDataValuesNoneValue Value { get; set; }

		[BinaryContent(Name = "WinLoseType", NodeType = BinaryContentTypes.Node)]
		public WinLoseType WinLoseType { get; set; }

		[BinaryContent(Name = "WinLoseState", NodeType = BinaryContentTypes.Node)]
		public NoneWinLoseState WinLoseState { get; set; }

		[BinaryContent(Name = "Winner", NodeType = BinaryContentTypes.Node)]
		public Winner Winner { get; set; }

	}
}
