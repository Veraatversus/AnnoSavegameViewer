namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class ActiveEffectsValue {

		[BinaryContent(Name = "scope", NodeType = BinaryContentTypes.Node)]
		public ActiveEffectsValuesNoneScope Scope { get; set; }

		[BinaryContent(Name = "distance", NodeType = BinaryContentTypes.Attribute)]
		public HexString Distance { get; set; }

		[BinaryContent(Name = "targetArea", NodeType = BinaryContentTypes.Attribute)]
		public HexString TargetArea { get; set; }

		[BinaryContent(Name = "targetParticipant", NodeType = BinaryContentTypes.Node)]
		public ValuesNoneTargetParticipant TargetParticipant { get; set; }

		[BinaryContent(Name = "effect", NodeType = BinaryContentTypes.Attribute)]
		public HexString Effect { get; set; }

		[BinaryContent(Name = "source", NodeType = BinaryContentTypes.Node)]
		public ActiveEffectsValuesNoneSource Source { get; set; }

		[BinaryContent(Name = "distanceSource", NodeType = BinaryContentTypes.Node)]
		public ValuesNoneDistanceSource DistanceSource { get; set; }

	}
}
