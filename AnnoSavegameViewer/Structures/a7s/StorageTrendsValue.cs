namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class StorageTrendsValue {

		[BinaryContent(Name = "Points", NodeType = BinaryContentTypes.Node)]
		public Points Points { get; set; }

		[BinaryContent(Name = "LastPointTime", NodeType = BinaryContentTypes.Attribute)]
		public TimeSpan LastPointTime { get; set; }

		[BinaryContent(Name = "Estimation", NodeType = BinaryContentTypes.Attribute)]
		public Int32 Estimation { get; set; }

	}
}
