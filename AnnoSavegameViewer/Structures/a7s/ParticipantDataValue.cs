namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ParticipantDataValue {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public ParticipantDataValuesNoneValue Value { get; set; }

		[BinaryContent(Name = "CurrentVolume", NodeType = BinaryContentTypes.Attribute)]
		public HexString CurrentVolume { get; set; }

		[BinaryContent(Name = "NewspaperCreateTimer", NodeType = BinaryContentTypes.Attribute)]
		public HexString NewspaperCreateTimer { get; set; }

		[BinaryContent(Name = "Target", NodeType = BinaryContentTypes.Node)]
		public Target Target { get; set; }

		[BinaryContent(Name = "Newspapers", NodeType = BinaryContentTypes.Node)]
		public Newspapers Newspapers { get; set; }

		[BinaryContent(Name = "NewspaperEvents", NodeType = BinaryContentTypes.Node)]
		public NewspaperEvents NewspaperEvents { get; set; }

		[BinaryContent(Name = "ArticleEffects", NodeType = BinaryContentTypes.Node)]
		public ArticleEffects ArticleEffects { get; set; }

		[BinaryContent(Name = "PriorityBonus", NodeType = BinaryContentTypes.Node)]
		public PriorityBonus PriorityBonus { get; set; }

		[BinaryContent(Name = "NewsTrackerCount", NodeType = BinaryContentTypes.Attribute)]
		public HexString NewsTrackerCount { get; set; }

		[BinaryContent(Name = "NewsTracker", NodeType = BinaryContentTypes.Node)]
		public NewsTracker NewsTracker { get; set; }

	}
}
