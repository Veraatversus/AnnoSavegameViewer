// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class AttackersValue {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public AttackersValuesNoneValue Value { get; set; }

		[BinaryContent(Name = "AmountOfShares", NodeType = BinaryContentTypes.Attribute)]
		public HexString AmountOfShares { get; set; }

		[BinaryContent(Name = "AmountOfMorale", NodeType = BinaryContentTypes.Attribute)]
		public HexString AmountOfMorale { get; set; }

	}
}
