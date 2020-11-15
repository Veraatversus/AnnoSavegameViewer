namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class TemplateElement {

		[BinaryContent(Name = "Element", NodeType = BinaryContentTypes.Node)]
		public TemplateElementElement Element { get; set; }

		[BinaryContent(Name = "ElementType", NodeType = BinaryContentTypes.Attribute)]
		public HexString ElementType { get; set; }

	}
}
