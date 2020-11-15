namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class CorporationProfile {

		[BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
		public Int64 ID { get; set; }

		[BinaryContent(Name = "PeerData", NodeType = BinaryContentTypes.Node)]
		public PeerData PeerData { get; set; }

		[BinaryContent(Name = "ActivationTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString ActivationTime { get; set; }

		[BinaryContent(Name = "CorporationTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString CorporationTime { get; set; }

		[BinaryContent(Name = "RequiredAccountUnlocks", NodeType = BinaryContentTypes.Node)]
		public RequiredAccountUnlocks RequiredAccountUnlocks { get; set; }

		[BinaryContent(Name = "AnsweredDlcUpgrade", NodeType = BinaryContentTypes.Node)]
		public AnsweredDlcUpgrade AnsweredDlcUpgrade { get; set; }

		[BinaryContent(Name = "DifficultyLevel", NodeType = BinaryContentTypes.Node)]
		public DifficultyLevel DifficultyLevel { get; set; }

		[BinaryContent(Name = "ParticipantID", NodeType = BinaryContentTypes.Node)]
		public ParticipantID ParticipantID { get; set; }

		[BinaryContent(Name = "GameSetup", NodeType = BinaryContentTypes.Node)]
		public GameSetup GameSetup { get; set; }

		[BinaryContent(Name = "Difficulty", NodeType = BinaryContentTypes.Node)]
		public Difficulty Difficulty { get; set; }

		[BinaryContent(Name = "SavegameHistory", NodeType = BinaryContentTypes.Node)]
		public SavegameHistory SavegameHistory { get; set; }

		[BinaryContent(Name = "AssetWatcher", NodeType = BinaryContentTypes.Node)]
		public AssetWatcher AssetWatcher { get; set; }

	}
}
