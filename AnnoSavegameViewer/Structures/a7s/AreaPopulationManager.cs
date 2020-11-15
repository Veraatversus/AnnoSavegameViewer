namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class AreaPopulationManager {

		[BinaryContent(Name = "CitySize", NodeType = BinaryContentTypes.Node)]
		public CitySize CitySize { get; set; }

		[BinaryContent(Name = "TriggeredBanners", NodeType = BinaryContentTypes.Node)]
		public TriggeredBanners TriggeredBanners { get; set; }

	}
}
