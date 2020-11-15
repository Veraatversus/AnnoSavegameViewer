namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class HarborHandler {

		[BinaryContent(Name = "SecurityFactor", NodeType = BinaryContentTypes.Attribute)]
		public HexString SecurityFactor { get; set; }

	}
}
