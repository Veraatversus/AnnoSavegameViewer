namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class AttackersValue {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public AttackersValuesNoneValue Value { get; set; }

		[BinaryContent(Name = "AmountOfShares", NodeType = BinaryContentTypes.Attribute)]
		public HexString AmountOfShares { get; set; }

		[BinaryContent(Name = "AmountOfMorale", NodeType = BinaryContentTypes.Attribute)]
		public HexString AmountOfMorale { get; set; }

	}
}
