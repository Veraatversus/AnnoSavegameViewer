namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class WorkforceTransferManagerParticipantDataValue {

		[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
		public WorkforceTransferManagerParticipantDataValuesNoneValue Value { get; set; }

		[BinaryContent(Name = "owner", NodeType = BinaryContentTypes.Node)]
		public ParticipantDataValuesNoneOwner Owner { get; set; }

		[BinaryContent(Name = "linkedAreas", NodeType = BinaryContentTypes.Node)]
		public LinkedAreas LinkedAreas { get; set; }

		[BinaryContent(Name = "feedbackRoute", NodeType = BinaryContentTypes.Attribute)]
		public HexString FeedbackRoute { get; set; }

		[BinaryContent(Name = "feedbackShips", NodeType = BinaryContentTypes.Node)]
		public FeedbackShips FeedbackShips { get; set; }

		[BinaryContent(Name = "pathEstimations", NodeType = BinaryContentTypes.Node)]
		public PathEstimations PathEstimations { get; set; }

		[BinaryContent(Name = "feedbackDist", NodeType = BinaryContentTypes.Attribute)]
		public Single FeedbackDist { get; set; }

		[BinaryContent(Name = "PaMSyTriggerSent", NodeType = BinaryContentTypes.Attribute)]
		public HexString PaMSyTriggerSent { get; set; }

	}
}
