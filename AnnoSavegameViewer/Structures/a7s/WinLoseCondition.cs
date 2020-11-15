namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class WinLoseCondition {

		[BinaryContent(Name = "ElementType", NodeType = BinaryContentTypes.Node)]
		public ElementType ElementType { get; set; }

		[BinaryContent(Name = "Owner", NodeType = BinaryContentTypes.Node)]
		public Owner Owner { get; set; }

	}
}
