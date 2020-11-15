namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class QuestObject {

		[BinaryContent(Name = "QuestIDs", NodeType = BinaryContentTypes.Node)]
		public QuestIDs QuestIDs { get; set; }

		[BinaryContent(Name = "ObjectWasVisible", NodeType = BinaryContentTypes.Node)]
		public ObjectWasVisible ObjectWasVisible { get; set; }

		[BinaryContent(Name = "OverwriteVisualParticipant", NodeType = BinaryContentTypes.Node)]
		public OverwriteVisualParticipant OverwriteVisualParticipant { get; set; }

	}
}
