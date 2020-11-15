namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class Pair {

		[BinaryContent(Name = "ParticipantID", NodeType = BinaryContentTypes.Node)]
		public PairParticipantID ParticipantID { get; set; }

		[BinaryContent(Name = "MetaEconomy", NodeType = BinaryContentTypes.Node)]
		public MetaEconomy MetaEconomy { get; set; }

	}
}
