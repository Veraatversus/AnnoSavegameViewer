namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ActiveDLCs {

		[BinaryContent(Name = "count", NodeType = BinaryContentTypes.Attribute)]
		public Int64 Count { get; set; }

		[BinaryContent(Name = "DLC", NodeType = BinaryContentTypes.Attribute)]
		public DescriptionInt DLC { get; set; }

	}
}
