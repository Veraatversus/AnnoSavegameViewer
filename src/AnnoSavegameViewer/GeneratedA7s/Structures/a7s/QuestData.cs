// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class QuestData {

		[BinaryContent(Name = "ShowMainSubobjective", NodeType = BinaryContentTypes.Attribute)]
		public HexString ShowMainSubobjective { get; set; }

		[BinaryContent(Name = "JumpToVisibility", NodeType = BinaryContentTypes.Node)]
		public JumpToVisibility JumpToVisibility { get; set; }

		[BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Attribute)]
		public HexString QuestID { get; set; }

		[BinaryContent(Name = "ConditionTextGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ConditionTextGUID { get; set; }

		[BinaryContent(Name = "ShowInQuestTracker", NodeType = BinaryContentTypes.Attribute)]
		public HexString ShowInQuestTracker { get; set; }

		[BinaryContent(Name = "IsMainObjective", NodeType = BinaryContentTypes.Attribute)]
		public HexString IsMainObjective { get; set; }

		[BinaryContent(Name = "SuccessorObjectiveID", NodeType = BinaryContentTypes.Attribute)]
		public HexString SuccessorObjectiveID { get; set; }

		[BinaryContent(Name = "ObjectiveIndex", NodeType = BinaryContentTypes.Attribute)]
		public HexString ObjectiveIndex { get; set; }

		[BinaryContent(Name = "QuestTrackerIcon", NodeType = BinaryContentTypes.Attribute)]
		public HexString QuestTrackerIcon { get; set; }

	}
}
