// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class WaitingRowArrayValuesNoneValue {

		[BinaryContent(Name = "Position", NodeType = BinaryContentTypes.Attribute)]
		public HexString Position { get; set; }

		[BinaryContent(Name = "InUse", NodeType = BinaryContentTypes.Attribute)]
		public HexString InUse { get; set; }

	}
}
