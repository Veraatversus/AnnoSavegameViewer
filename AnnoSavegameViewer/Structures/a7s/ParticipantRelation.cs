namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ParticipantRelation {

		[BinaryContent(Name = "Source", NodeType = BinaryContentTypes.Node)]
		public Source Source { get; set; }

		[BinaryContent(Name = "Target", NodeType = BinaryContentTypes.Node)]
		public ParticipantRelationTarget Target { get; set; }

	}
}
