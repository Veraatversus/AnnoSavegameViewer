// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class ParticipantRelation {

		[BinaryContent(Name = "Source", NodeType = BinaryContentTypes.Node)]
		public Source Source { get; set; }

		[BinaryContent(Name = "Target", NodeType = BinaryContentTypes.Node)]
		public ParticipantRelationTarget Target { get; set; }

	}
}
