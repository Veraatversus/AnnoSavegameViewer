namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class Block_01 {

		[BinaryContent(Name = "header.a7s", NodeType = BinaryContentTypes.Node, CompressionType = CompressionTypes.Zlib, ConversationType = ConversationTypes.FileDB, RdaFile = "header.a7s")]
		public Header_a7s Header_a7s { get; set; }

	}
}
