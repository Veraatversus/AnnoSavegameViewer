namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class NoneStackValue {

		[BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
		public Int64 ID { get; set; }

		[BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
		public DescriptionInt GUID { get; set; }

	}
}
