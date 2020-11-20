// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class ValuesNoneObjectFilter {

		[BinaryContent(Name = "ObjectGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ObjectGUID { get; set; }

		[BinaryContent(Name = "ObjectParticipant", NodeType = BinaryContentTypes.Node)]
		public NoneObjectFilterObjectParticipant ObjectParticipant { get; set; }

		[BinaryContent(Name = "IslandNames", NodeType = BinaryContentTypes.Node)]
		public NoneObjectFilterIslandNames IslandNames { get; set; }

		[BinaryContent(Name = "SessionGUID", NodeType = BinaryContentTypes.Node)]
		public NoneObjectFilterSessionGUID SessionGUID { get; set; }

		[BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Node)]
		public NoneObjectFilterQuestID QuestID { get; set; }

	}
}
