// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class FogsOfWarValue {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public FogsOfWarValuesNoneValue Value { get; set; }

		[BinaryContent(Name = "DirtyPositions", NodeType = BinaryContentTypes.Node)]
		public DirtyPositions DirtyPositions { get; set; }

		[BinaryContent(Name = "LastReHideTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastReHideTime { get; set; }

	}
}
