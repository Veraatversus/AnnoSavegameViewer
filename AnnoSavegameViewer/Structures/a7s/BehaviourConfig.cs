namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class BehaviourConfig {

		[BinaryContent(Name = "OriginatorObj", NodeType = BinaryContentTypes.Node)]
		public OriginatorObj OriginatorObj { get; set; }

		[BinaryContent(Name = "Com", NodeType = BinaryContentTypes.Node)]
		public Com Com { get; set; }

		[BinaryContent(Name = "Region", NodeType = BinaryContentTypes.Node)]
		public BehaviourConfigRegion Region { get; set; }

	}
}
