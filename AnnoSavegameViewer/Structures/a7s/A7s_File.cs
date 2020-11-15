namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class A7s_File {

		[BinaryContent(Name = "a7s_File", NodeType = BinaryContentTypes.Node, ConversationType = ConversationTypes.RDA)]
		public A7s_File_RDA A7s_File_RDA { get; set; }

	}
}
