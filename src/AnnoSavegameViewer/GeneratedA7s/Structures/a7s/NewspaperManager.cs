// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class NewspaperManager {

		[BinaryContent(Name = "IDManager", NodeType = BinaryContentTypes.Node)]
		public IDManager IDManager { get; set; }

		[BinaryContent(Name = "ParticipantData", NodeType = BinaryContentTypes.Node)]
		public ParticipantData ParticipantData { get; set; }

	}
}
