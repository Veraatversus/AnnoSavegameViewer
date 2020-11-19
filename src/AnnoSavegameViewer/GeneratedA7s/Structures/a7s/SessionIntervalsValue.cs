// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System.Collections.Generic;

	public partial class SessionIntervalsValue : ValuesList<SessionIntervalsValuesNoneValue> {

		[BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
		public override List<SessionIntervalsValuesNoneValue> Values { get; set; }

		[BinaryContent(Name = "IntervalEnd", NodeType = BinaryContentTypes.Attribute)]
		public HexString IntervalEnd { get; set; }

		[BinaryContent(Name = "BonusChance", NodeType = BinaryContentTypes.Attribute)]
		public HexString BonusChance { get; set; }

	}
}
