namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class Pirate {

		[BinaryContent(Name = "AreaOfActivity", NodeType = BinaryContentTypes.Node)]
		public AreaOfActivity AreaOfActivity { get; set; }

		[BinaryContent(Name = "ChaseRange", NodeType = BinaryContentTypes.Attribute)]
		public HexString ChaseRange { get; set; }

		[BinaryContent(Name = "UsesEntirePlayableArea", NodeType = BinaryContentTypes.Attribute)]
		public HexString UsesEntirePlayableArea { get; set; }

		[BinaryContent(Name = "ComebackAt", NodeType = BinaryContentTypes.Attribute)]
		public HexString ComebackAt { get; set; }

		[BinaryContent(Name = "OfferCeasefireAt", NodeType = BinaryContentTypes.Attribute)]
		public HexString OfferCeasefireAt { get; set; }

		[BinaryContent(Name = "ComebackQuestIDs", NodeType = BinaryContentTypes.Attribute)]
		public HexString ComebackQuestIDs { get; set; }

		[BinaryContent(Name = "Kontor", NodeType = BinaryContentTypes.Node)]
		public Kontor Kontor { get; set; }

	}
}
