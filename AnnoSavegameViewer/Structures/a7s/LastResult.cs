namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class LastResult {

		[BinaryContent(Name = "LastResult", NodeType = BinaryContentTypes.Node)]
		public LastResultLastResult LastResultItem { get; set; }

		[BinaryContent(Name = "Defender", NodeType = BinaryContentTypes.Node)]
		public Defender Defender { get; set; }

		[BinaryContent(Name = "Attackers", NodeType = BinaryContentTypes.Node)]
		public Attackers Attackers { get; set; }

		[BinaryContent(Name = "OriginalShareOwner", NodeType = BinaryContentTypes.Node)]
		public OriginalShareOwner OriginalShareOwner { get; set; }

		[BinaryContent(Name = "MoraleLeft", NodeType = BinaryContentTypes.Attribute)]
		public HexString MoraleLeft { get; set; }

	}
}
