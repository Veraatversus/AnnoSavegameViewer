using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class TradeRoutesList {

    [BinaryContent(Name = "Route", NodeType = BinaryContentTypes.Attribute)]
    public object Route { get; set; }

    [BinaryContent(Name = "RoundTravel", NodeType = BinaryContentTypes.Attribute)]
    public object RoundTravel { get; set; }

    [BinaryContent(Name = "ShipID", NodeType = BinaryContentTypes.Attribute)]
    public object ShipID { get; set; }

    [BinaryContent(Name = "EstablishTime", NodeType = BinaryContentTypes.Attribute)]
    public object EstablishTime { get; set; }

    [BinaryContent(Name = "TransportTasks", NodeType = BinaryContentTypes.Node)]
    public TransportTasks TransportTasks { get; set; }

    [BinaryContent(Name = "RouteType", NodeType = BinaryContentTypes.Node)]
    public RouteType RouteType { get; set; }

  }
}