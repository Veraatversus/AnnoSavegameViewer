namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class TradeRouteEntriesListList {

    [BinaryContent(Name = "TraderShip", NodeType = BinaryContentTypes.Attribute)]
    public object TraderShip { get; set; }

    [BinaryContent(Name = "ExecutionTime", NodeType = BinaryContentTypes.Attribute)]
    public object ExecutionTime { get; set; }

    [BinaryContent(Name = "Finalized", NodeType = BinaryContentTypes.Attribute)]
    public object Finalized { get; set; }

    [BinaryContent(Name = "RouteID", NodeType = BinaryContentTypes.Attribute)]
    public object RouteID { get; set; }

    [BinaryContent(Name = "RouteName", NodeType = BinaryContentTypes.Attribute)]
    public object RouteName { get; set; }

    [BinaryContent(Name = "Trader", NodeType = BinaryContentTypes.Node)]
    public TradeRouteEntriesListListTrader Trader { get; set; }

    [BinaryContent(Name = "TradedGoods", NodeType = BinaryContentTypes.Node)]
    public TradeRouteEntriesListListTradedGoods TradedGoods { get; set; }

  }
}