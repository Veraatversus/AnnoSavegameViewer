// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class MetaInteractionCurrentTradeStatusValuesNoneValue {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public CurrentTradeStatusValuesNoneValuesNoneValue Value { get; set; }

		[BinaryContent(Name = "Step", NodeType = BinaryContentTypes.Attribute)]
		public HexString Step { get; set; }

		[BinaryContent(Name = "CurrentAmount", NodeType = BinaryContentTypes.Attribute)]
		public HexString CurrentAmount { get; set; }

	}
}
