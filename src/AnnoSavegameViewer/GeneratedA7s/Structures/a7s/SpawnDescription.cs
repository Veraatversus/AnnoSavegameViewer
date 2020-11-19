// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class SpawnDescription {

		[BinaryContent(Name = "AreaType", NodeType = BinaryContentTypes.Attribute)]
		public HexString AreaType { get; set; }

		[BinaryContent(Name = "SpawnAmount", NodeType = BinaryContentTypes.Attribute)]
		public HexString SpawnAmount { get; set; }

		[BinaryContent(Name = "ContextObjectID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ContextObjectID { get; set; }

		[BinaryContent(Name = "ContextPosition", NodeType = BinaryContentTypes.Attribute)]
		public HexString ContextPosition { get; set; }

		[BinaryContent(Name = "DistanceToBorder", NodeType = BinaryContentTypes.Attribute)]
		public HexString DistanceToBorder { get; set; }

		[BinaryContent(Name = "DistanceToIsland", NodeType = BinaryContentTypes.Attribute)]
		public HexString DistanceToIsland { get; set; }

		[BinaryContent(Name = "SpawnContextType", NodeType = BinaryContentTypes.Node)]
		public SpawnContextType SpawnContextType { get; set; }

		[BinaryContent(Name = "ParticipantIDClient", NodeType = BinaryContentTypes.Node)]
		public ParticipantIDClient ParticipantIDClient { get; set; }

		[BinaryContent(Name = "ParticipantIDPlayer", NodeType = BinaryContentTypes.Node)]
		public ParticipantIDPlayer ParticipantIDPlayer { get; set; }

		[BinaryContent(Name = "SpreadObject", NodeType = BinaryContentTypes.Attribute)]
		public HexString SpreadObject { get; set; }

		[BinaryContent(Name = "ContextObjectLabel", NodeType = BinaryContentTypes.Attribute)]
		public HexString ContextObjectLabel { get; set; }

		[BinaryContent(Name = "DistanceToContext", NodeType = BinaryContentTypes.Attribute)]
		public HexString DistanceToContext { get; set; }

		[BinaryContent(Name = "MinObjectDistance", NodeType = BinaryContentTypes.Attribute)]
		public HexString MinObjectDistance { get; set; }

		[BinaryContent(Name = "MaxObjectDistance", NodeType = BinaryContentTypes.Attribute)]
		public HexString MaxObjectDistance { get; set; }

		[BinaryContent(Name = "ContextGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ContextGUID { get; set; }

		[BinaryContent(Name = "ContextMarkerLabel", NodeType = BinaryContentTypes.Attribute)]
		public HexString ContextMarkerLabel { get; set; }

		[BinaryContent(Name = "LimitToQuestArea", NodeType = BinaryContentTypes.Attribute)]
		public HexString LimitToQuestArea { get; set; }

		[BinaryContent(Name = "MatcherGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString MatcherGUID { get; set; }

	}
}
