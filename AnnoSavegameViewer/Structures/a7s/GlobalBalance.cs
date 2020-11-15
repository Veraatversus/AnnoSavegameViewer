namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class GlobalBalance {

		[BinaryContent(Name = "MoneyDelta", NodeType = BinaryContentTypes.Node)]
		public MoneyDelta MoneyDelta { get; set; }

		[BinaryContent(Name = "RubberbandFactor", NodeType = BinaryContentTypes.Attribute)]
		public HexString RubberbandFactor { get; set; }

		[BinaryContent(Name = "LastBalanceUpdate", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastBalanceUpdate { get; set; }

		[BinaryContent(Name = "LastGoodsUpdate", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastGoodsUpdate { get; set; }

		[BinaryContent(Name = "OtherRegionDeltas", NodeType = BinaryContentTypes.Node)]
		public OtherRegionDeltas OtherRegionDeltas { get; set; }

		[BinaryContent(Name = "Balance0", NodeType = BinaryContentTypes.Node)]
		public Balance0 Balance0 { get; set; }

	}
}
