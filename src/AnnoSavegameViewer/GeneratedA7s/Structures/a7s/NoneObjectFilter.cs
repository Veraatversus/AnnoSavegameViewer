// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class NoneObjectFilter {

		[BinaryContent(Name = "ObjectParticipant", NodeType = BinaryContentTypes.Node)]
		public ObjectFilterObjectParticipant ObjectParticipant { get; set; }

		[BinaryContent(Name = "IslandNames", NodeType = BinaryContentTypes.Node)]
		public ObjectFilterIslandNames IslandNames { get; set; }

		[BinaryContent(Name = "SessionGUID", NodeType = BinaryContentTypes.Node)]
		public ObjectFilterSessionGUID SessionGUID { get; set; }

		[BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Node)]
		public ObjectFilterQuestID QuestID { get; set; }

	}
}
