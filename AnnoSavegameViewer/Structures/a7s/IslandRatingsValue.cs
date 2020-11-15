namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class IslandRatingsValue {

		[BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
		public HexString AreaID { get; set; }

		[BinaryContent(Name = "Category", NodeType = BinaryContentTypes.Attribute)]
		public HexString Category { get; set; }

		[BinaryContent(Name = "Priority", NodeType = BinaryContentTypes.Attribute)]
		public HexString Priority { get; set; }

	}
}
