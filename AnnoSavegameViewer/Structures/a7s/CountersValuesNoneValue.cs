namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class CountersValuesNoneValue {

		[BinaryContent(Name = "PlayerCounter", NodeType = BinaryContentTypes.Node)]
		public ValuesNonePlayerCounter PlayerCounter { get; set; }

		[BinaryContent(Name = "Context", NodeType = BinaryContentTypes.Attribute)]
		public HexString Context { get; set; }

		[BinaryContent(Name = "Value", NodeType = BinaryContentTypes.Attribute)]
		public HexString Value { get; set; }

	}
}
