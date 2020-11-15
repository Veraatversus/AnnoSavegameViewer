namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class WinLoseManager {

		[BinaryContent(Name = "LoseConditionsCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString LoseConditionsCount { get; set; }

		[BinaryContent(Name = "ParticipantsWinLoseData", NodeType = BinaryContentTypes.Node)]
		public ParticipantsWinLoseData ParticipantsWinLoseData { get; set; }

		[BinaryContent(Name = "WinLoseCondition", NodeType = BinaryContentTypes.Node)]
		public WinLoseCondition WinLoseCondition { get; set; }

	}
}
