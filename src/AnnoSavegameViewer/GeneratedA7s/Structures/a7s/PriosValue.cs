// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class PriosValue {

		[BinaryContent(Name = "Time", NodeType = BinaryContentTypes.Attribute)]
		public HexString Time { get; set; }

		[BinaryContent(Name = "Count", NodeType = BinaryContentTypes.Attribute)]
		public HexString Count { get; set; }

		[BinaryContent(Name = "Modifier", NodeType = BinaryContentTypes.Attribute)]
		public HexString Modifier { get; set; }

	}
}
