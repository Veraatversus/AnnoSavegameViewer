// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class ExpeditionsValue {

		[BinaryContent(Name = "guid", NodeType = BinaryContentTypes.Attribute)]
		public HexString Guid { get; set; }

		[BinaryContent(Name = "owner", NodeType = BinaryContentTypes.Node)]
		public ExpeditionsValuesNoneOwner Owner { get; set; }

		[BinaryContent(Name = "permission", NodeType = BinaryContentTypes.Attribute)]
		public HexString Permission { get; set; }

		[BinaryContent(Name = "state", NodeType = BinaryContentTypes.Node)]
		public NoneState State { get; set; }

		[BinaryContent(Name = "expeditionShip", NodeType = BinaryContentTypes.Attribute)]
		public HexString ExpeditionShip { get; set; }

		[BinaryContent(Name = "events", NodeType = BinaryContentTypes.Attribute)]
		public HexString Events { get; set; }

		[BinaryContent(Name = "threats", NodeType = BinaryContentTypes.Attribute)]
		public HexString Threats { get; set; }

		[BinaryContent(Name = "threatDescriptions", NodeType = BinaryContentTypes.Attribute)]
		public HexString ThreatDescriptions { get; set; }

		[BinaryContent(Name = "threatWeight", NodeType = BinaryContentTypes.Node)]
		public ThreatWeight ThreatWeight { get; set; }

		[BinaryContent(Name = "lastNegativeOutcomeLosses", NodeType = BinaryContentTypes.Node)]
		public LastNegativeOutcomeLosses LastNegativeOutcomeLosses { get; set; }

		[BinaryContent(Name = "lastRewardContainer", NodeType = BinaryContentTypes.Node)]
		public LastRewardContainer LastRewardContainer { get; set; }

		[BinaryContent(Name = "lastRewardResources", NodeType = BinaryContentTypes.Node)]
		public LastRewardResources LastRewardResources { get; set; }

		[BinaryContent(Name = "lastRewardPermits", NodeType = BinaryContentTypes.Node)]
		public LastRewardPermits LastRewardPermits { get; set; }

		[BinaryContent(Name = "feedOptionFactors", NodeType = BinaryContentTypes.Node)]
		public FeedOptionFactors FeedOptionFactors { get; set; }

		[BinaryContent(Name = "startTimeStamp", NodeType = BinaryContentTypes.Attribute)]
		public HexString StartTimeStamp { get; set; }

		[BinaryContent(Name = "preparation", NodeType = BinaryContentTypes.Node)]
		public Preparation Preparation { get; set; }

		[BinaryContent(Name = "visitedMapOptions", NodeType = BinaryContentTypes.Attribute)]
		public HexString VisitedMapOptions { get; set; }

		[BinaryContent(Name = "returnToKontor", NodeType = BinaryContentTypes.Attribute)]
		public HexString ReturnToKontor { get; set; }

		[BinaryContent(Name = "worldMapAssetCreated", NodeType = BinaryContentTypes.Attribute)]
		public HexString WorldMapAssetCreated { get; set; }

		[BinaryContent(Name = "startSession", NodeType = BinaryContentTypes.Attribute)]
		public HexString StartSession { get; set; }

		[BinaryContent(Name = "startEventCountdown", NodeType = BinaryContentTypes.Attribute)]
		public HexString StartEventCountdown { get; set; }

		[BinaryContent(Name = "currentEventIndex", NodeType = BinaryContentTypes.Attribute)]
		public HexString CurrentEventIndex { get; set; }

		[BinaryContent(Name = "currentDecision", NodeType = BinaryContentTypes.Attribute)]
		public HexString CurrentDecision { get; set; }

		[BinaryContent(Name = "morale", NodeType = BinaryContentTypes.Attribute)]
		public HexString Morale { get; set; }

		[BinaryContent(Name = "lastUsedRequirement", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastUsedRequirement { get; set; }

		[BinaryContent(Name = "lastOption", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastOption { get; set; }

		[BinaryContent(Name = "shipGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ShipGUID { get; set; }

		[BinaryContent(Name = "shipSlotCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString ShipSlotCount { get; set; }

		[BinaryContent(Name = "expeditionSlot", NodeType = BinaryContentTypes.Attribute)]
		public HexString ExpeditionSlot { get; set; }

		[BinaryContent(Name = "totalTravelTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString TotalTravelTime { get; set; }

	}
}
