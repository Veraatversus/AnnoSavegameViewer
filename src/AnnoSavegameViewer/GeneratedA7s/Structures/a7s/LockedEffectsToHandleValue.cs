// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class LockedEffectsToHandleValue {

		[BinaryContent(Name = "Ministry", NodeType = BinaryContentTypes.Node)]
		public NoneMinistry Ministry { get; set; }

		[BinaryContent(Name = "Decree", NodeType = BinaryContentTypes.Node)]
		public NoneDecree Decree { get; set; }

	}
}
