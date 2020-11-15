namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ProductionState {

		[BinaryContent(Name = "InProgress", NodeType = BinaryContentTypes.Attribute)]
		public Boolean InProgress { get; set; }

		[BinaryContent(Name = "RemainingTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString RemainingTime { get; set; }

		[BinaryContent(Name = "Productivity", NodeType = BinaryContentTypes.Attribute)]
		public Single Productivity { get; set; }

	}
}
