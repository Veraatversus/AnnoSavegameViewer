namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class MetaGameManager {

		[BinaryContent(Name = "GameCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString GameCount { get; set; }

		[BinaryContent(Name = "GameTotal", NodeType = BinaryContentTypes.Attribute)]
		public HexString GameTotal { get; set; }

		[BinaryContent(Name = "CreatingAccountID", NodeType = BinaryContentTypes.Attribute, Encoding = "")]
		public String CreatingAccountID { get; set; }

		[BinaryContent(Name = "NetworkSafeRandom", NodeType = BinaryContentTypes.Node)]
		public NetworkSafeRandom NetworkSafeRandom { get; set; }

		[BinaryContent(Name = "FunFactSettings", NodeType = BinaryContentTypes.Node)]
		public FunFactSettings FunFactSettings { get; set; }

		[BinaryContent(Name = "StartSessionGUID", NodeType = BinaryContentTypes.Attribute)]
		public DescriptionInt StartSessionGUID { get; set; }

		[BinaryContent(Name = "PeerToSessionMap", NodeType = BinaryContentTypes.Node)]
		public PeerToSessionMap PeerToSessionMap { get; set; }

		[BinaryContent(Name = "MetaUnlockManager", NodeType = BinaryContentTypes.Node)]
		public MetaUnlockManager MetaUnlockManager { get; set; }

		[BinaryContent(Name = "NotificationSystem", NodeType = BinaryContentTypes.Node)]
		public NotificationSystem NotificationSystem { get; set; }

		[BinaryContent(Name = "MetaGameObjectManager", NodeType = BinaryContentTypes.Node)]
		public MetaGameObjectManager MetaGameObjectManager { get; set; }

		[BinaryContent(Name = "ParticipantManager", NodeType = BinaryContentTypes.Node)]
		public ParticipantManager ParticipantManager { get; set; }

		[BinaryContent(Name = "ParticipantMessageManager", NodeType = BinaryContentTypes.Node)]
		public ParticipantMessageManager ParticipantMessageManager { get; set; }

		[BinaryContent(Name = "ParticipantUnlockManager", NodeType = BinaryContentTypes.Node)]
		public ParticipantUnlockManager ParticipantUnlockManager { get; set; }

		[BinaryContent(Name = "ToolOneManager", NodeType = BinaryContentTypes.Node)]
		public ToolOneManager ToolOneManager { get; set; }

		[BinaryContent(Name = "ConditionManager", NodeType = BinaryContentTypes.Node)]
		public ConditionManager ConditionManager { get; set; }

		[BinaryContent(Name = "QuestManager", NodeType = BinaryContentTypes.Node)]
		public QuestManager QuestManager { get; set; }

		[BinaryContent(Name = "EconomyManager", NodeType = BinaryContentTypes.Node)]
		public EconomyManager EconomyManager { get; set; }

		[BinaryContent(Name = "EconomyStatisticManager", NodeType = BinaryContentTypes.Node)]
		public EconomyStatisticManager EconomyStatisticManager { get; set; }

		[BinaryContent(Name = "CorporationDlcUpgradeManager", NodeType = BinaryContentTypes.Node)]
		public CorporationDlcUpgradeManager CorporationDlcUpgradeManager { get; set; }

		[BinaryContent(Name = "FullscreenMovieQueueManager", NodeType = BinaryContentTypes.Node)]
		public FullscreenMovieQueueManager FullscreenMovieQueueManager { get; set; }

		[BinaryContent(Name = "WinLoseManager", NodeType = BinaryContentTypes.Node)]
		public WinLoseManager WinLoseManager { get; set; }

		[BinaryContent(Name = "NewspaperManager", NodeType = BinaryContentTypes.Node)]
		public NewspaperManager NewspaperManager { get; set; }

		[BinaryContent(Name = "SessionTradeRouteManager", NodeType = BinaryContentTypes.Node)]
		public SessionTradeRouteManager SessionTradeRouteManager { get; set; }

		[BinaryContent(Name = "SessionTransferManager", NodeType = BinaryContentTypes.Node)]
		public SessionTransferManager SessionTransferManager { get; set; }

		[BinaryContent(Name = "UniqueNamingManager", NodeType = BinaryContentTypes.Node)]
		public UniqueNamingManager UniqueNamingManager { get; set; }

		[BinaryContent(Name = "TextureAtlasManager", NodeType = BinaryContentTypes.Node)]
		public TextureAtlasManager TextureAtlasManager { get; set; }

		[BinaryContent(Name = "MetaSoundManager", NodeType = BinaryContentTypes.Node)]
		public MetaSoundManager MetaSoundManager { get; set; }

		[BinaryContent(Name = "MetaMessageManager", NodeType = BinaryContentTypes.Node)]
		public MetaMessageManager MetaMessageManager { get; set; }

		[BinaryContent(Name = "DaytimeManager", NodeType = BinaryContentTypes.Node)]
		public DaytimeManager DaytimeManager { get; set; }

		[BinaryContent(Name = "MetaIncidentManager", NodeType = BinaryContentTypes.Node)]
		public MetaIncidentManager MetaIncidentManager { get; set; }

		[BinaryContent(Name = "GameSessions", NodeType = BinaryContentTypes.Node)]
		public GameSessions GameSessions { get; set; }

	}
}
