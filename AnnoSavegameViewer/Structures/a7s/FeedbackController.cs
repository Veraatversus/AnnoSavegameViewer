namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class FeedbackController {

		[BinaryContent(Name = "CurrentSequence", NodeType = BinaryContentTypes.Attribute)]
		public HexString CurrentSequence { get; set; }

		[BinaryContent(Name = "OverrideSequence", NodeType = BinaryContentTypes.Node)]
		public OverrideSequence OverrideSequence { get; set; }

		[BinaryContent(Name = "SequenceStartTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString SequenceStartTime { get; set; }

		[BinaryContent(Name = "ForcedActorVariation", NodeType = BinaryContentTypes.Attribute)]
		public HexString ForcedActorVariation { get; set; }

		[BinaryContent(Name = "IsFeedbackEnabled", NodeType = BinaryContentTypes.Attribute)]
		public HexString IsFeedbackEnabled { get; set; }

	}
}
