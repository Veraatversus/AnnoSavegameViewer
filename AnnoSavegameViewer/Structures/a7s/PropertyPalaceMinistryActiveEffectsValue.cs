namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class PropertyPalaceMinistryActiveEffectsValue {

		[BinaryContent(Name = "scope", NodeType = BinaryContentTypes.Node)]
		public PropertyPalaceMinistryActiveEffectsValuesNoneScope Scope { get; set; }

		[BinaryContent(Name = "distance", NodeType = BinaryContentTypes.Attribute)]
		public HexString Distance { get; set; }

		[BinaryContent(Name = "targetArea", NodeType = BinaryContentTypes.Attribute)]
		public HexString TargetArea { get; set; }

		[BinaryContent(Name = "targetParticipant", NodeType = BinaryContentTypes.Node)]
		public ActiveEffectsValuesNoneTargetParticipant TargetParticipant { get; set; }

		[BinaryContent(Name = "effect", NodeType = BinaryContentTypes.Attribute)]
		public HexString Effect { get; set; }

		[BinaryContent(Name = "source", NodeType = BinaryContentTypes.Node)]
		public PropertyPalaceMinistryActiveEffectsValuesNoneSource Source { get; set; }

		[BinaryContent(Name = "distanceSource", NodeType = BinaryContentTypes.Node)]
		public ActiveEffectsValuesNoneDistanceSource DistanceSource { get; set; }

	}
}
