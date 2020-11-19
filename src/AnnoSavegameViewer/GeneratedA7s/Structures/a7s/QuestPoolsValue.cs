// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class QuestPoolsValue {

		[BinaryContent(Name = "questPoolGUID", NodeType = BinaryContentTypes.Attribute)]
		public Int32 QuestPoolGUID { get; set; }

		[BinaryContent(Name = "OptionalCooldownTimestamp", NodeType = BinaryContentTypes.Node)]
		public OptionalCooldownTimestamp OptionalCooldownTimestamp { get; set; }

		[BinaryContent(Name = "QuestBlockings", NodeType = BinaryContentTypes.Node)]
		public QuestBlockings QuestBlockings { get; set; }

		[BinaryContent(Name = "IsEnabled", NodeType = BinaryContentTypes.Attribute)]
		public HexString IsEnabled { get; set; }

	}
}
