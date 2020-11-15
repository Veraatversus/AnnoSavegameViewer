namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class Block_00 {

		[BinaryContent(Name = "meta.a7s", NodeType = BinaryContentTypes.Node, CompressionType = CompressionTypes.Zlib, ConversationType = ConversationTypes.FileDB, RdaFile = "meta.a7s")]
		public Meta_a7s Meta_a7s { get; set; }

	}
}
