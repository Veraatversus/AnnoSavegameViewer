using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PropertyTradeRouteVehicle {

    [BinaryContent(Name = "TargetBuildingID", NodeType = BinaryContentTypes.Attribute)]
    public object TargetBuildingID { get; set; }

    [BinaryContent(Name = "TargetLoadingHarbour", NodeType = BinaryContentTypes.Attribute)]
    public object TargetLoadingHarbour { get; set; }

    [BinaryContent(Name = "TradeRouteID", NodeType = BinaryContentTypes.Attribute)]
    public object TradeRouteID { get; set; }

    [BinaryContent(Name = "TargetStationID", NodeType = BinaryContentTypes.Attribute)]
    public object TargetStationID { get; set; }

    [BinaryContent(Name = "HarbourEvaluated", NodeType = BinaryContentTypes.Attribute)]
    public object HarbourEvaluated { get; set; }

    [BinaryContent(Name = "ForceUpdateMovement", NodeType = BinaryContentTypes.Attribute)]
    public object ForceUpdateMovement { get; set; }

    [BinaryContent(Name = "WaypointIndex", NodeType = BinaryContentTypes.Attribute)]
    public object WaypointIndex { get; set; }

    [BinaryContent(Name = "WaitingTime", NodeType = BinaryContentTypes.Attribute)]
    public object WaitingTime { get; set; }

    [BinaryContent(Name = "RouteStatus", NodeType = BinaryContentTypes.Node)]
    public RouteStatus RouteStatus { get; set; }

    [BinaryContent(Name = "PlannedLoad", NodeType = BinaryContentTypes.Node)]
    public PlannedLoad PlannedLoad { get; set; }

    [BinaryContent(Name = "TradeDescription", NodeType = BinaryContentTypes.Node)]
    public TradeDescription TradeDescription { get; set; }

  }
}