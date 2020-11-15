namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class RewardGenerator {

		[BinaryContent(Name = "RewardList", NodeType = BinaryContentTypes.Node)]
		public RewardList RewardList { get; set; }

		[BinaryContent(Name = "IsOptionalQuest", NodeType = BinaryContentTypes.Attribute)]
		public HexString IsOptionalQuest { get; set; }

		[BinaryContent(Name = "QuestDifficulty", NodeType = BinaryContentTypes.Node)]
		public QuestDifficulty QuestDifficulty { get; set; }

		[BinaryContent(Name = "ExpeditionDifficulty", NodeType = BinaryContentTypes.Node)]
		public ExpeditionDifficulty ExpeditionDifficulty { get; set; }

		[BinaryContent(Name = "ExpeditionRegion", NodeType = BinaryContentTypes.Node)]
		public ExpeditionRegion ExpeditionRegion { get; set; }

	}
}
