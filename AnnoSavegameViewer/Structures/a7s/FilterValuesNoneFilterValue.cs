namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class FilterValuesNoneFilterValue {

		[BinaryContent(Name = "FolderID", NodeType = BinaryContentTypes.Attribute)]
		public HexString FolderID { get; set; }

		[BinaryContent(Name = "Filter", NodeType = BinaryContentTypes.Node)]
		public NoneFilterValuesNoneFilter Filter { get; set; }

	}
}
