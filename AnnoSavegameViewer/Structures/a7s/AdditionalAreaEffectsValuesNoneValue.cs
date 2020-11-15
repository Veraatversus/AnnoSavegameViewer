namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class AdditionalAreaEffectsValuesNoneValue {

		[BinaryContent(Name = "scope", NodeType = BinaryContentTypes.Node)]
		public ValuesNoneScope Scope { get; set; }

		[BinaryContent(Name = "distance", NodeType = BinaryContentTypes.Attribute)]
		public Int32 Distance { get; set; }

		[BinaryContent(Name = "targetArea", NodeType = BinaryContentTypes.Attribute)]
		public Int16 TargetArea { get; set; }

		[BinaryContent(Name = "targetParticipant", NodeType = BinaryContentTypes.Node)]
		public NoneTargetParticipant TargetParticipant { get; set; }

		[BinaryContent(Name = "effect", NodeType = BinaryContentTypes.Attribute)]
		public DescriptionInt Effect { get; set; }

		[BinaryContent(Name = "source", NodeType = BinaryContentTypes.Node)]
		public NoneValuesNoneSource Source { get; set; }

		[BinaryContent(Name = "distanceSource", NodeType = BinaryContentTypes.Node)]
		public NoneDistanceSource DistanceSource { get; set; }

	}
}
