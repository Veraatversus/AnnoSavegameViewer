// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class Monument {

		[BinaryContent(Name = "ProductionState", NodeType = BinaryContentTypes.Node)]
		public MonumentProductionState ProductionState { get; set; }

		[BinaryContent(Name = "EventGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString EventGUID { get; set; }

		[BinaryContent(Name = "EventState", NodeType = BinaryContentTypes.Attribute)]
		public HexString EventState { get; set; }

		[BinaryContent(Name = "EventRewards2", NodeType = BinaryContentTypes.Node)]
		public EventRewards2 EventRewards2 { get; set; }

		[BinaryContent(Name = "EventPreparation", NodeType = BinaryContentTypes.Node)]
		public EventPreparation EventPreparation { get; set; }

		[BinaryContent(Name = "eventAttractiveness", NodeType = BinaryContentTypes.Attribute)]
		public HexString EventAttractiveness { get; set; }

		[BinaryContent(Name = "lastReducedAttractivenessTimestamp", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastReducedAttractivenessTimestamp { get; set; }

		[BinaryContent(Name = "feedbackTextAmount", NodeType = BinaryContentTypes.Attribute)]
		public HexString FeedbackTextAmount { get; set; }

		[BinaryContent(Name = "FeedbackTextIcon", NodeType = BinaryContentTypes.Attribute)]
		public HexString FeedbackTextIcon { get; set; }

		[BinaryContent(Name = "FeedbackTextGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString FeedbackTextGUID { get; set; }

		[BinaryContent(Name = "FeedbackTextPosition", NodeType = BinaryContentTypes.Attribute)]
		public HexString FeedbackTextPosition { get; set; }

	}
}
