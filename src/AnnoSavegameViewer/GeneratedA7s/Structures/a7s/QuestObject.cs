// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class QuestObject {

		[BinaryContent(Name = "QuestIDs", NodeType = BinaryContentTypes.Node)]
		public QuestIDs QuestIDs { get; set; }

		[BinaryContent(Name = "ObjectWasVisible", NodeType = BinaryContentTypes.Node)]
		public ObjectWasVisible ObjectWasVisible { get; set; }

		[BinaryContent(Name = "OverwriteVisualParticipant", NodeType = BinaryContentTypes.Node)]
		public OverwriteVisualParticipant OverwriteVisualParticipant { get; set; }

	}
}
