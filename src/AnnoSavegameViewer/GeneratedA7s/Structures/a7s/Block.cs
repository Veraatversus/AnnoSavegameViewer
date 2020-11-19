// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using System;

	public partial class Block {

		[BinaryContent(Name = "mode", NodeType = BinaryContentTypes.Attribute)]
		public Byte Mode { get; set; }

		[BinaryContent(Name = "x", NodeType = BinaryContentTypes.Attribute)]
		public Int16 X { get; set; }

		[BinaryContent(Name = "y", NodeType = BinaryContentTypes.Attribute)]
		public Int16 Y { get; set; }

		[BinaryContent(Name = "default", NodeType = BinaryContentTypes.Node)]
		public Default Default { get; set; }

		[BinaryContent(Name = "values", NodeType = BinaryContentTypes.Node)]
		public BlockValues Values { get; set; }

	}
}
