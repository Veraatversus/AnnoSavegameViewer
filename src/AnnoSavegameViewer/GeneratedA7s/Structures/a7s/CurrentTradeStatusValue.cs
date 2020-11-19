// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System.Collections.Generic;

	public partial class CurrentTradeStatusValue : ValuesList<MetaInteractionCurrentTradeStatusValuesNoneValue> {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public CurrentTradeStatusValuesNoneValue Value { get; set; }

		[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
		public override List<MetaInteractionCurrentTradeStatusValuesNoneValue> Values { get; set; }

	}
}
