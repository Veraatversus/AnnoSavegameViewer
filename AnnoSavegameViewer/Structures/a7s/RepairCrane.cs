namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class RepairCrane {

		[BinaryContent(Name = "currentRepairTarget", NodeType = BinaryContentTypes.Attribute)]
		public HexString CurrentRepairTarget { get; set; }

	}
}
