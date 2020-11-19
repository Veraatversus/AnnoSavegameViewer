// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using System;

	public partial class SavegameHistoryValue {

		[BinaryContent(Name = "Timestamp", NodeType = BinaryContentTypes.Attribute)]
		public DateTime Timestamp { get; set; }

		[BinaryContent(Name = "Changelist", NodeType = BinaryContentTypes.Attribute)]
		public Int32 Changelist { get; set; }

		[BinaryContent(Name = "RequiredUnlocks", NodeType = BinaryContentTypes.Node)]
		public RequiredUnlocks RequiredUnlocks { get; set; }

	}
}
