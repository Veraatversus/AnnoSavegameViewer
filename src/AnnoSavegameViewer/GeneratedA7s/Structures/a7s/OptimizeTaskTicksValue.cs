// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class OptimizeTaskTicksValue {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public OptimizeTaskTicksValuesNoneValue Value { get; set; }

		[BinaryContent(Name = "LastTrigger", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastTrigger { get; set; }

		[BinaryContent(Name = "BuildCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString BuildCount { get; set; }

	}
}
