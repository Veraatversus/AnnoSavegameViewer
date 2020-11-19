// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class RemovedProps {

		[BinaryContent(Name = "x", NodeType = BinaryContentTypes.Attribute)]
		public HexString X { get; set; }

		[BinaryContent(Name = "y", NodeType = BinaryContentTypes.Attribute)]
		public HexString Y { get; set; }

		[BinaryContent(Name = "bits", NodeType = BinaryContentTypes.Attribute)]
		public HexString Bits { get; set; }

	}
}
