// Copyright � 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class Context {

		[BinaryContent(Name = "ArticleGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ArticleGUID { get; set; }

		[BinaryContent(Name = "ParticipantID", NodeType = BinaryContentTypes.Node)]
		public ContextParticipantID ParticipantID { get; set; }

		[BinaryContent(Name = "TownID", NodeType = BinaryContentTypes.Attribute)]
		public HexString TownID { get; set; }

		[BinaryContent(Name = "ObjectRef", NodeType = BinaryContentTypes.Node)]
		public ObjectRef ObjectRef { get; set; }

		[BinaryContent(Name = "TownName", NodeType = BinaryContentTypes.Attribute)]
		public HexString TownName { get; set; }

		[BinaryContent(Name = "Owner", NodeType = BinaryContentTypes.Node)]
		public ContextOwner Owner { get; set; }

		[BinaryContent(Name = "ParticipantName", NodeType = BinaryContentTypes.Attribute)]
		public HexString ParticipantName { get; set; }

	}
}
