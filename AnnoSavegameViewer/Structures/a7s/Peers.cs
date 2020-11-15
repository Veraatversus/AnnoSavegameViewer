namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class Peers {

		[BinaryContent(Name = "count", NodeType = BinaryContentTypes.Attribute)]
		public HexString Count { get; set; }

		[BinaryContent(Name = "Peer", NodeType = BinaryContentTypes.Node)]
		public Peer Peer { get; set; }

	}
}
