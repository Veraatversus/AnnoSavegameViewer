// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System.Collections.Generic;

	public partial class PassiveTradeEntriesValue : ValuesList<HistoryPassiveTradeEntriesValuesNoneValue> {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public PassiveTradeEntriesValuesNoneValue Value { get; set; }

		[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
		public override List<HistoryPassiveTradeEntriesValuesNoneValue> Values { get; set; }

	}
}
