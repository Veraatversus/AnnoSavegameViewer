namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class Trader {

    [BinaryContent(Name = "tradeRouteID", NodeType = BinaryContentTypes.Attribute)]
    public object TradeRouteID { get; set; }

    [BinaryContent(Name = "sellCooldowns", NodeType = BinaryContentTypes.Attribute)]
    public object SellCooldowns { get; set; }

    [BinaryContent(Name = "rerollTimer", NodeType = BinaryContentTypes.Attribute)]
    public object RerollTimer { get; set; }

    [BinaryContent(Name = "lastShipProduction", NodeType = BinaryContentTypes.Attribute)]
    public object LastShipProduction { get; set; }

    [BinaryContent(Name = "currentSellAmount", NodeType = BinaryContentTypes.Attribute)]
    public object CurrentSellAmount { get; set; }

    [BinaryContent(Name = "shipToBuildGUID", NodeType = BinaryContentTypes.Attribute)]
    public object ShipToBuildGUID { get; set; }

    [BinaryContent(Name = "shipBuildTimer", NodeType = BinaryContentTypes.Attribute)]
    public object ShipBuildTimer { get; set; }

    [BinaryContent(Name = "offeredItems", NodeType = BinaryContentTypes.Node)]
    public OfferedItems OfferedItems { get; set; }

    [BinaryContent(Name = "productGain", NodeType = BinaryContentTypes.Node)]
    public ProductGain ProductGain { get; set; }

    [BinaryContent(Name = "nextProductionType", NodeType = BinaryContentTypes.Node)]
    public NextProductionType NextProductionType { get; set; }

    [BinaryContent(Name = "warships", NodeType = BinaryContentTypes.Node)]
    public Warships Warships { get; set; }

    [BinaryContent(Name = "tradeships", NodeType = BinaryContentTypes.Node)]
    public TraderTradeships Tradeships { get; set; }

    [BinaryContent(Name = "sellships", NodeType = BinaryContentTypes.Node)]
    public Sellships Sellships { get; set; }

    [BinaryContent(Name = "replacementOffers", NodeType = BinaryContentTypes.Node)]
    public ReplacementOffers ReplacementOffers { get; set; }

  }
}