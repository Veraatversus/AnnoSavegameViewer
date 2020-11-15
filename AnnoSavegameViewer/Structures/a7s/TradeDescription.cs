namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class TradeDescription {

		[BinaryContent(Name = "TradeInfos", NodeType = BinaryContentTypes.Node)]
		public TradeInfos TradeInfos { get; set; }

		[BinaryContent(Name = "Source", NodeType = BinaryContentTypes.Node)]
		public TradeDescriptionSource Source { get; set; }

		[BinaryContent(Name = "Target", NodeType = BinaryContentTypes.Node)]
		public TradeDescriptionTarget Target { get; set; }

		[BinaryContent(Name = "Area", NodeType = BinaryContentTypes.Attribute)]
		public Int16 Area { get; set; }

		[BinaryContent(Name = "PassiveTradeBuilding", NodeType = BinaryContentTypes.Node)]
		public PassiveTradeBuilding PassiveTradeBuilding { get; set; }

		[BinaryContent(Name = "TargetShip", NodeType = BinaryContentTypes.Attribute)]
		public DescriptionInt TargetShip { get; set; }

		[BinaryContent(Name = "TradeRouteID", NodeType = BinaryContentTypes.Attribute)]
		public Int32 TradeRouteID { get; set; }

		[BinaryContent(Name = "SellingMoney", NodeType = BinaryContentTypes.Node)]
		public SellingMoney SellingMoney { get; set; }

		[BinaryContent(Name = "BuyingMoney", NodeType = BinaryContentTypes.Node)]
		public BuyingMoney BuyingMoney { get; set; }

		[BinaryContent(Name = "TotalTradeGoodAmount", NodeType = BinaryContentTypes.Attribute)]
		public Int32 TotalTradeGoodAmount { get; set; }

	}
}
