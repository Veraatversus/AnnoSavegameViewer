namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class Block_03 {

		[BinaryContent(Name = "data.a7s", NodeType = BinaryContentTypes.Node, CompressionType = CompressionTypes.Zlib, ConversationType = ConversationTypes.FileDB, RdaFile = "data.a7s")]
		public Data_a7s Data_a7s { get; set; }

	}
}
