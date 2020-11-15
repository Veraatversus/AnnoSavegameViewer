namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class AreaInfoValue {

		[BinaryContent(Name = "Fertility", NodeType = BinaryContentTypes.Node)]
		public Fertility Fertility { get; set; }

		[BinaryContent(Name = "CityNameGuid", NodeType = BinaryContentTypes.Attribute)]
		public DescriptionInt CityNameGuid { get; set; }

		[BinaryContent(Name = "CityNameIterator", NodeType = BinaryContentTypes.Attribute)]
		public Int32 CityNameIterator { get; set; }

		[BinaryContent(Name = "CityName", NodeType = BinaryContentTypes.Attribute, Encoding = "utf-16")]
		public String CityName { get; set; }

		[BinaryContent(Name = "Owner", NodeType = BinaryContentTypes.Node)]
		public AreaInfoValuesNoneOwner Owner { get; set; }

		[BinaryContent(Name = "WasEverOwned", NodeType = BinaryContentTypes.Attribute)]
		public Boolean WasEverOwned { get; set; }

		[BinaryContent(Name = "ShareInfos", NodeType = BinaryContentTypes.Node)]
		public ShareInfos ShareInfos { get; set; }

		[BinaryContent(Name = "ShareCoolDowns", NodeType = BinaryContentTypes.Node)]
		public ShareCoolDowns ShareCoolDowns { get; set; }

		[BinaryContent(Name = "AreaEconomy", NodeType = BinaryContentTypes.Node)]
		public AreaEconomy AreaEconomy { get; set; }

		[BinaryContent(Name = "PassiveTrade", NodeType = BinaryContentTypes.Node)]
		public PassiveTrade PassiveTrade { get; set; }

		[BinaryContent(Name = "MilTakeOverData", NodeType = BinaryContentTypes.Node)]
		public MilTakeOverData MilTakeOverData { get; set; }

	}
}
