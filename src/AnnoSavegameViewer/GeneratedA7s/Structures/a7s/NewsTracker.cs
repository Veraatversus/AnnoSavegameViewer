// Copyright � 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class NewsTracker {

		[BinaryContent(Name = "ElementType", NodeType = BinaryContentTypes.Node)]
		public NewsTrackerElementType ElementType { get; set; }

		[BinaryContent(Name = "Target", NodeType = BinaryContentTypes.Node)]
		public NewsTrackerTarget Target { get; set; }

		[BinaryContent(Name = "Type", NodeType = BinaryContentTypes.Node)]
		public NewsTrackerType Type { get; set; }

		[BinaryContent(Name = "Scope", NodeType = BinaryContentTypes.Node)]
		public NewsTrackerScope Scope { get; set; }

		[BinaryContent(Name = "Area", NodeType = BinaryContentTypes.Attribute)]
		public HexString Area { get; set; }

		[BinaryContent(Name = "AssetDataGuid", NodeType = BinaryContentTypes.Attribute)]
		public HexString AssetDataGuid { get; set; }

		[BinaryContent(Name = "GlobalTriggered", NodeType = BinaryContentTypes.Attribute)]
		public HexString GlobalTriggered { get; set; }

		[BinaryContent(Name = "AreaTriggered", NodeType = BinaryContentTypes.Node)]
		public AreaTriggered AreaTriggered { get; set; }

		[BinaryContent(Name = "GlobalCounter", NodeType = BinaryContentTypes.Node)]
		public GlobalCounter GlobalCounter { get; set; }

		[BinaryContent(Name = "AreaCounter", NodeType = BinaryContentTypes.Node)]
		public AreaCounter AreaCounter { get; set; }

		[BinaryContent(Name = "TrackedData", NodeType = BinaryContentTypes.Node)]
		public TrackedData TrackedData { get; set; }

		[BinaryContent(Name = "InfectionChanceTracker", NodeType = BinaryContentTypes.Node)]
		public InfectionChanceTracker InfectionChanceTracker { get; set; }

		[BinaryContent(Name = "NextCheck", NodeType = BinaryContentTypes.Attribute)]
		public HexString NextCheck { get; set; }

		[BinaryContent(Name = "SettledTracker", NodeType = BinaryContentTypes.Node)]
		public SettledTracker SettledTracker { get; set; }

		[BinaryContent(Name = "ReputationOnStart", NodeType = BinaryContentTypes.Node)]
		public ReputationOnStart ReputationOnStart { get; set; }

		[BinaryContent(Name = "SpecialEditionInitiator", NodeType = BinaryContentTypes.Node)]
		public SpecialEditionInitiator SpecialEditionInitiator { get; set; }

		[BinaryContent(Name = "QuestsFailed", NodeType = BinaryContentTypes.Attribute)]
		public HexString QuestsFailed { get; set; }

		[BinaryContent(Name = "ShipsDestroyed", NodeType = BinaryContentTypes.Attribute)]
		public HexString ShipsDestroyed { get; set; }

		[BinaryContent(Name = "MoralePointsLost", NodeType = BinaryContentTypes.Attribute)]
		public HexString MoralePointsLost { get; set; }

		[BinaryContent(Name = "BattleActive", NodeType = BinaryContentTypes.Attribute)]
		public HexString BattleActive { get; set; }

		[BinaryContent(Name = "Session", NodeType = BinaryContentTypes.Attribute)]
		public HexString Session { get; set; }

		[BinaryContent(Name = "Tracked", NodeType = BinaryContentTypes.Node)]
		public Tracked Tracked { get; set; }

		[BinaryContent(Name = "PopulationOnStart", NodeType = BinaryContentTypes.Attribute)]
		public HexString PopulationOnStart { get; set; }

		[BinaryContent(Name = "HappinessOnStart", NodeType = BinaryContentTypes.Attribute)]
		public HexString HappinessOnStart { get; set; }

		[BinaryContent(Name = "DurationTracked", NodeType = BinaryContentTypes.Node)]
		public DurationTracked DurationTracked { get; set; }

		[BinaryContent(Name = "ProductivityTracker", NodeType = BinaryContentTypes.Node)]
		public ProductivityTracker ProductivityTracker { get; set; }

		[BinaryContent(Name = "CityStatusOnIntervalStart", NodeType = BinaryContentTypes.Attribute)]
		public HexString CityStatusOnIntervalStart { get; set; }

	}
}
