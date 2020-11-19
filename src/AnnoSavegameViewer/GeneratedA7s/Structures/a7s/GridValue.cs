// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class GridValue {

		[BinaryContent(Name = "FreeTiles", NodeType = BinaryContentTypes.Attribute)]
		public HexString FreeTiles { get; set; }

		[BinaryContent(Name = "DistanceToBlocker", NodeType = BinaryContentTypes.Attribute)]
		public HexString DistanceToBlocker { get; set; }

	}
}
