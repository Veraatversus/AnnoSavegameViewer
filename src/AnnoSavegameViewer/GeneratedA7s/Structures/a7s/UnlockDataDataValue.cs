// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class UnlockDataDataValue {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public UnlockDataDataValuesNoneValue Value { get; set; }

		[BinaryContent(Name = "LockState", NodeType = BinaryContentTypes.Node)]
		public NoneLockState LockState { get; set; }

	}
}
