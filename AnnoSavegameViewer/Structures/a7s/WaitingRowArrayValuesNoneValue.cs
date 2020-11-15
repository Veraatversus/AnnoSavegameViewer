namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class WaitingRowArrayValuesNoneValue {

		[BinaryContent(Name = "Position", NodeType = BinaryContentTypes.Attribute)]
		public HexString Position { get; set; }

		[BinaryContent(Name = "InUse", NodeType = BinaryContentTypes.Attribute)]
		public HexString InUse { get; set; }

	}
}
