namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class SessionParticipantManager {

		[BinaryContent(Name = "ParticipantIDToObjects", NodeType = BinaryContentTypes.Node)]
		public ParticipantIDToObjects ParticipantIDToObjects { get; set; }

	}
}
