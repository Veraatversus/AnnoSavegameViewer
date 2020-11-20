// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class VarMapData {

		[BinaryContent(Name = "SparseEnabled", NodeType = BinaryContentTypes.Attribute)]
		public HexString SparseEnabled { get; set; }

		[BinaryContent(Name = "x", NodeType = BinaryContentTypes.Attribute)]
		public Int32 X { get; set; }

		[BinaryContent(Name = "y", NodeType = BinaryContentTypes.Attribute)]
		public Int32 Y { get; set; }

		[BinaryContent(Name = "block", NodeType = BinaryContentTypes.Node)]
		public Block Block { get; set; }

	}
}
