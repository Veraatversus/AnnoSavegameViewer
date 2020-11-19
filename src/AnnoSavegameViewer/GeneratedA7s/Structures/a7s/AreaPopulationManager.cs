// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;

	public partial class AreaPopulationManager {

		[BinaryContent(Name = "CitySize", NodeType = BinaryContentTypes.Node)]
		public CitySize CitySize { get; set; }

		[BinaryContent(Name = "TriggeredBanners", NodeType = BinaryContentTypes.Node)]
		public TriggeredBanners TriggeredBanners { get; set; }

	}
}
