// Copyright � 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class A7s_File_RDA {

		[BinaryContent(Name = "Block 00", NodeType = BinaryContentTypes.Node, RdaBlock = 0)]
		public Block_00 Block_00 { get; set; }

		[BinaryContent(Name = "Block 01", NodeType = BinaryContentTypes.Node, RdaBlock = 1)]
		public Block_01 Block_01 { get; set; }

		[BinaryContent(Name = "Block 02", NodeType = BinaryContentTypes.Node, RdaBlock = 2)]
		public Block_02 Block_02 { get; set; }

		[BinaryContent(Name = "Block 03", NodeType = BinaryContentTypes.Node, RdaBlock = 3)]
		public Block_03 Block_03 { get; set; }

	}
}
