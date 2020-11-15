namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class PeerSpecificData {

		[BinaryContent(Name = "SessionData", NodeType = BinaryContentTypes.Node)]
		public PeerSpecificDataSessionData SessionData { get; set; }

	}
}
