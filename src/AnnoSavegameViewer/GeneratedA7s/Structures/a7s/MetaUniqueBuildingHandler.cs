// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class MetaUniqueBuildingHandler {

		[BinaryContent(Name = "AreaUniques", NodeType = BinaryContentTypes.Node)]
		public AreaUniques AreaUniques { get; set; }

		[BinaryContent(Name = "SessionUniques", NodeType = BinaryContentTypes.Node)]
		public SessionUniques SessionUniques { get; set; }

		[BinaryContent(Name = "GameUniques", NodeType = BinaryContentTypes.Node)]
		public GameUniques GameUniques { get; set; }

	}
}
