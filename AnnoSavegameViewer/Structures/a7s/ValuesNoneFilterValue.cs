namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ValuesNoneFilterValue {

		[BinaryContent(Name = "FolderID", NodeType = BinaryContentTypes.Attribute)]
		public Int32 FolderID { get; set; }

		[BinaryContent(Name = "Filter", NodeType = BinaryContentTypes.Node)]
		public FilterValuesNoneFilter Filter { get; set; }

	}
}
