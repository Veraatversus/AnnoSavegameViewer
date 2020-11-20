// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class DataValue {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public DataValuesNoneValue Value { get; set; }

		[BinaryContent(Name = "OwnerID", NodeType = BinaryContentTypes.Node)]
		public OwnerID OwnerID { get; set; }

		[BinaryContent(Name = "QuestLatencies", NodeType = BinaryContentTypes.Node)]
		public QuestLatencies QuestLatencies { get; set; }

		[BinaryContent(Name = "QuestDelays", NodeType = BinaryContentTypes.Node)]
		public QuestDelays QuestDelays { get; set; }

		[BinaryContent(Name = "QuestPriorities", NodeType = BinaryContentTypes.Node)]
		public QuestPriorities QuestPriorities { get; set; }

		[BinaryContent(Name = "QuestLineProgress", NodeType = BinaryContentTypes.Node)]
		public QuestLineProgress QuestLineProgress { get; set; }

		[BinaryContent(Name = "QuestPools", NodeType = BinaryContentTypes.Node)]
		public QuestPools QuestPools { get; set; }

	}
}
