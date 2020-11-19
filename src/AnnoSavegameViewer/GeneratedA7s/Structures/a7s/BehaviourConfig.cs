// Copyright � 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class BehaviourConfig {

		[BinaryContent(Name = "OriginatorObj", NodeType = BinaryContentTypes.Node)]
		public OriginatorObj OriginatorObj { get; set; }

		[BinaryContent(Name = "Com", NodeType = BinaryContentTypes.Node)]
		public Com Com { get; set; }

		[BinaryContent(Name = "Region", NodeType = BinaryContentTypes.Node)]
		public BehaviourConfigRegion Region { get; set; }

	}
}
