// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class CommandGroupInformation {

		[BinaryContent(Name = "OverwriteSetitng", NodeType = BinaryContentTypes.Node)]
		public OverwriteSetitng OverwriteSetitng { get; set; }

		[BinaryContent(Name = "GroupInformation", NodeType = BinaryContentTypes.Node)]
		public GroupInformation GroupInformation { get; set; }

	}
}
