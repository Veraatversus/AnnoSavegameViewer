namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class DistributionPausedInfoValue {

		[BinaryContent(Name = "DistributionPaused", NodeType = BinaryContentTypes.Attribute)]
		public HexString DistributionPaused { get; set; }

		[BinaryContent(Name = "CurrentlyProvided", NodeType = BinaryContentTypes.Attribute)]
		public HexString CurrentlyProvided { get; set; }

	}
}
