namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class TradeRoute {

    [BinaryContent(Name = "NextShipID", NodeType = BinaryContentTypes.Attribute)]
    public object NextShipID { get; set; }

    [BinaryContent(Name = "TradeShips", NodeType = BinaryContentTypes.Node)]
    public TradeRouteTradeShips TradeShips { get; set; }

    [BinaryContent(Name = "TradeRoutes", NodeType = BinaryContentTypes.Node)]
    public TradeRouteTradeRoutes TradeRoutes { get; set; }

    [BinaryContent(Name = "UnassignedTasks", NodeType = BinaryContentTypes.Node)]
    public TradeRouteUnassignedTasks UnassignedTasks { get; set; }

    [BinaryContent(Name = "KilledShipRoutes", NodeType = BinaryContentTypes.Node)]
    public TradeRouteKilledShipRoutes KilledShipRoutes { get; set; }

  }
}