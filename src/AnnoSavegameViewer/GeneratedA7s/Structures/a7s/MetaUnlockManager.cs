// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class MetaUnlockManager {

		[BinaryContent(Name = "LockState", NodeType = BinaryContentTypes.Node)]
		public LockState LockState { get; set; }

	}
}
