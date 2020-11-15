namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class DelayedActionsValuesNoneObjectFilter {

		[BinaryContent(Name = "ObjectGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ObjectGUID { get; set; }

		[BinaryContent(Name = "ObjectParticipant", NodeType = BinaryContentTypes.Node)]
		public ValuesNoneObjectFilterObjectParticipant ObjectParticipant { get; set; }

		[BinaryContent(Name = "IslandNames", NodeType = BinaryContentTypes.Node)]
		public ValuesNoneObjectFilterIslandNames IslandNames { get; set; }

		[BinaryContent(Name = "SessionGUID", NodeType = BinaryContentTypes.Node)]
		public ValuesNoneObjectFilterSessionGUID SessionGUID { get; set; }

		[BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Node)]
		public ValuesNoneObjectFilterQuestID QuestID { get; set; }

	}
}
