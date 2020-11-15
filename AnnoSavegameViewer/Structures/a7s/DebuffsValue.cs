namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class DebuffsValue {

		[BinaryContent(Name = "DebuffEnd", NodeType = BinaryContentTypes.Attribute)]
		public HexString DebuffEnd { get; set; }

		[BinaryContent(Name = "DiceDebuff", NodeType = BinaryContentTypes.Attribute)]
		public HexString DiceDebuff { get; set; }

	}
}
