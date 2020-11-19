// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class PathBackground {

		[BinaryContent(Name = "CurrentPath", NodeType = BinaryContentTypes.Attribute)]
		public HexString CurrentPath { get; set; }

	}
}
