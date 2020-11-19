// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class AreaAttractivityManager {

		[BinaryContent(Name = "BaseNatureAttractiveness", NodeType = BinaryContentTypes.Attribute)]
		public HexString BaseNatureAttractiveness { get; set; }

		[BinaryContent(Name = "TriggeredBanners", NodeType = BinaryContentTypes.Node)]
		public AreaAttractivityManagerTriggeredBanners TriggeredBanners { get; set; }

		[BinaryContent(Name = "TriggeredBannersNew", NodeType = BinaryContentTypes.Node)]
		public TriggeredBannersNew TriggeredBannersNew { get; set; }

		[BinaryContent(Name = "MaxCityStatus", NodeType = BinaryContentTypes.Attribute)]
		public HexString MaxCityStatus { get; set; }

		[BinaryContent(Name = "CurCityStatus", NodeType = BinaryContentTypes.Attribute)]
		public HexString CurCityStatus { get; set; }

		[BinaryContent(Name = "MaxParagonShown", NodeType = BinaryContentTypes.Attribute)]
		public HexString MaxParagonShown { get; set; }

	}
}
