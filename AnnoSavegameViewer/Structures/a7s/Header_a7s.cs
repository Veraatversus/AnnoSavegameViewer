namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class Header_a7s {

		[BinaryContent(Name = "CorporationProfile", NodeType = BinaryContentTypes.Node)]
		public CorporationProfile CorporationProfile { get; set; }

	}
}
