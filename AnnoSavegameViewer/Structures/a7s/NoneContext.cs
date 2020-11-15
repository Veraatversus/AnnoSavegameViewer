namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class NoneContext {

		[BinaryContent(Name = "ArticleGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ArticleGUID { get; set; }

		[BinaryContent(Name = "ParticipantID", NodeType = BinaryContentTypes.Node)]
		public NoneContextParticipantID ParticipantID { get; set; }

		[BinaryContent(Name = "TownID", NodeType = BinaryContentTypes.Attribute)]
		public HexString TownID { get; set; }

		[BinaryContent(Name = "ObjectRef", NodeType = BinaryContentTypes.Node)]
		public ContextObjectRef ObjectRef { get; set; }

		[BinaryContent(Name = "ParticipantName", NodeType = BinaryContentTypes.Attribute)]
		public HexString ParticipantName { get; set; }

		[BinaryContent(Name = "Owner", NodeType = BinaryContentTypes.Node)]
		public NoneContextOwner Owner { get; set; }

		[BinaryContent(Name = "TownName", NodeType = BinaryContentTypes.Attribute)]
		public HexString TownName { get; set; }

		[BinaryContent(Name = "ObjectGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ObjectGUID { get; set; }

		[BinaryContent(Name = "ObjectName", NodeType = BinaryContentTypes.Attribute)]
		public HexString ObjectName { get; set; }

	}
}
