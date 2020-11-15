namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class TradeDescription {

    [BinaryContent(Name = "Area", NodeType = BinaryContentTypes.Attribute)]
    public object Area { get; set; }

    [BinaryContent(Name = "TargetShip", NodeType = BinaryContentTypes.Attribute)]
    public object TargetShip { get; set; }

    [BinaryContent(Name = "TradeRouteID", NodeType = BinaryContentTypes.Attribute)]
    public object TradeRouteID { get; set; }

    [BinaryContent(Name = "TotalTradeGoodAmount", NodeType = BinaryContentTypes.Attribute)]
    public object TotalTradeGoodAmount { get; set; }

    [BinaryContent(Name = "TradeInfos", NodeType = BinaryContentTypes.Node)]
    public TradeInfos TradeInfos { get; set; }

    [BinaryContent(Name = "Source", NodeType = BinaryContentTypes.Node)]
    public TradeDescriptionSource Source { get; set; }

    [BinaryContent(Name = "Target", NodeType = BinaryContentTypes.Node)]
    public TradeDescriptionTarget Target { get; set; }

    [BinaryContent(Name = "PassiveTradeBuilding", NodeType = BinaryContentTypes.Node)]
    public PassiveTradeBuilding PassiveTradeBuilding { get; set; }

    [BinaryContent(Name = "SellingMoney", NodeType = BinaryContentTypes.Node)]
    public SellingMoney SellingMoney { get; set; }

    [BinaryContent(Name = "BuyingMoney", NodeType = BinaryContentTypes.Node)]
    public BuyingMoney BuyingMoney { get; set; }

  }
}