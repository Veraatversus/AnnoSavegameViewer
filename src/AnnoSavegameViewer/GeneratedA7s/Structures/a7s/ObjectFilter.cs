// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class ObjectFilter {

		[BinaryContent(Name = "ObjectGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ObjectGUID { get; set; }

		[BinaryContent(Name = "ObjectParticipant", NodeType = BinaryContentTypes.Node)]
		public ObjectParticipant ObjectParticipant { get; set; }

		[BinaryContent(Name = "IslandNames", NodeType = BinaryContentTypes.Node)]
		public IslandNames IslandNames { get; set; }

		[BinaryContent(Name = "SessionGUID", NodeType = BinaryContentTypes.Node)]
		public SessionGUID SessionGUID { get; set; }

		[BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Node)]
		public QuestID QuestID { get; set; }

		[BinaryContent(Name = "CheckParticipantID", NodeType = BinaryContentTypes.Attribute)]
		public HexString CheckParticipantID { get; set; }

		[BinaryContent(Name = "UseProcessingParticipantID", NodeType = BinaryContentTypes.Attribute)]
		public HexString UseProcessingParticipantID { get; set; }

	}
}
