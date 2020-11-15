namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class DriftingInstruction {

		[BinaryContent(Name = "DriftingInstruction", NodeType = BinaryContentTypes.Attribute)]
		public HexString DriftingInstructionItem { get; set; }

	}
}
