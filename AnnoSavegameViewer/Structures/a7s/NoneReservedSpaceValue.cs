namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class NoneReservedSpaceValue {

		[BinaryContent(Name = "Parent", NodeType = BinaryContentTypes.Node)]
		public ReservedSpaceValuesNoneParent Parent { get; set; }

		[BinaryContent(Name = "Type", NodeType = BinaryContentTypes.Attribute)]
		public Int32 Type { get; set; }

		[BinaryContent(Name = "Index", NodeType = BinaryContentTypes.Attribute)]
		public Int64 Index { get; set; }

	}
}
