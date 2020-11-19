// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class Stats {

		[BinaryContent(Name = "AreaCounter", NodeType = BinaryContentTypes.Node)]
		public StatsAreaCounter AreaCounter { get; set; }

		[BinaryContent(Name = "SessionCounter", NodeType = BinaryContentTypes.Node)]
		public SessionCounter SessionCounter { get; set; }

		[BinaryContent(Name = "RegionCounter", NodeType = BinaryContentTypes.Node)]
		public RegionCounter RegionCounter { get; set; }

		[BinaryContent(Name = "GlobalCounter", NodeType = BinaryContentTypes.Node)]
		public StatsGlobalCounter GlobalCounter { get; set; }

	}
}
