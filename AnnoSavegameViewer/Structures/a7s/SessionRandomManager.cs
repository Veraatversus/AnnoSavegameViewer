namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class SessionRandomManager {

		[BinaryContent(Name = "NetworkSafeRandom", NodeType = BinaryContentTypes.Node)]
		public SessionRandomManagerNetworkSafeRandom NetworkSafeRandom { get; set; }

	}
}
