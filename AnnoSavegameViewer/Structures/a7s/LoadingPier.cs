namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class LoadingPier {

		[BinaryContent(Name = "LoadingHarbourID", NodeType = BinaryContentTypes.Attribute)]
		public Int64 LoadingHarbourID { get; set; }

		[BinaryContent(Name = "CurrentTradePartnerArray", NodeType = BinaryContentTypes.Node)]
		public CurrentTradePartnerArray CurrentTradePartnerArray { get; set; }

	}
}
