namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class PassiveTradeHistory {

    [BinaryContent(Name = "PassiveTradeEntries", NodeType = BinaryContentTypes.Node)]
    public PassiveTradeEntries PassiveTradeEntries { get; set; }

    [BinaryContent(Name = "TradeRouteEntries", NodeType = BinaryContentTypes.Node)]
    public TradeRouteEntries TradeRouteEntries { get; set; }

  }
}