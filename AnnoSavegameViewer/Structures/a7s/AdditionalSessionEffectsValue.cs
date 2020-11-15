namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class AdditionalSessionEffectsValue {

		[BinaryContent(Name = "scope", NodeType = BinaryContentTypes.Node)]
		public NoneScope Scope { get; set; }

		[BinaryContent(Name = "targetArea", NodeType = BinaryContentTypes.Attribute)]
		public Int16 TargetArea { get; set; }

		[BinaryContent(Name = "targetParticipant", NodeType = BinaryContentTypes.Node)]
		public TargetParticipant TargetParticipant { get; set; }

		[BinaryContent(Name = "effect", NodeType = BinaryContentTypes.Attribute)]
		public DescriptionInt Effect { get; set; }

		[BinaryContent(Name = "source", NodeType = BinaryContentTypes.Node)]
		public AdditionalSessionEffectsValuesNoneSource Source { get; set; }

		[BinaryContent(Name = "distanceSource", NodeType = BinaryContentTypes.Node)]
		public DistanceSource DistanceSource { get; set; }

	}
}
