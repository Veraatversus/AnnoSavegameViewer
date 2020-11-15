namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class LastKilledValue {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public LastKilledValuesNoneValue Value { get; set; }

		[BinaryContent(Name = "LastAttack", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastAttack { get; set; }

		[BinaryContent(Name = "SecondLastAttack", NodeType = BinaryContentTypes.Attribute)]
		public HexString SecondLastAttack { get; set; }

	}
}
