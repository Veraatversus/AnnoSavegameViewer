namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class Other {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public OtherValue Value { get; set; }

	}
}
