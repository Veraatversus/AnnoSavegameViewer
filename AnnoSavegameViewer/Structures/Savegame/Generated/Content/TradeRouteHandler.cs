using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class TradeRouteHandler {

    [BinaryContent(Name = "NextShipID", NodeType = BinaryContentTypes.Attribute)]
    public object NextShipID { get; set; }

    [BinaryContent(Name = "TradeShips", NodeType = BinaryContentTypes.Node)]
    public TradeShips TradeShips { get; set; }

    [BinaryContent(Name = "TradeRoutes", NodeType = BinaryContentTypes.Node)]
    public TradeRoutes TradeRoutes { get; set; }

    [BinaryContent(Name = "UnassignedTasks", NodeType = BinaryContentTypes.Node)]
    public UnassignedTasks UnassignedTasks { get; set; }

    [BinaryContent(Name = "KilledShipRoutes", NodeType = BinaryContentTypes.Node)]
    public KilledShipRoutes KilledShipRoutes { get; set; }

  }
}