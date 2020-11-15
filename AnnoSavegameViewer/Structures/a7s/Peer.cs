namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class Peer {

		[BinaryContent(Name = "Values", NodeType = BinaryContentTypes.Node)]
		public PeerValues Values { get; set; }

	}
}
