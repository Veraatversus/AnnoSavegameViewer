namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class PropertyTradeRouteVehicle {

    [BinaryContent(Name = "TradeRouteID", NodeType = BinaryContentTypes.Attribute)]
    public object TradeRouteID { get; set; }

    [BinaryContent(Name = "TargetStationID", NodeType = BinaryContentTypes.Attribute)]
    public object TargetStationID { get; set; }

    [BinaryContent(Name = "TargetBuildingID", NodeType = BinaryContentTypes.Attribute)]
    public object TargetBuildingID { get; set; }

    [BinaryContent(Name = "TargetLoadingHarbour", NodeType = BinaryContentTypes.Attribute)]
    public object TargetLoadingHarbour { get; set; }

    [BinaryContent(Name = "ForceUpdateMovement", NodeType = BinaryContentTypes.Attribute)]
    public object ForceUpdateMovement { get; set; }

    [BinaryContent(Name = "HarbourEvaluated", NodeType = BinaryContentTypes.Attribute)]
    public object HarbourEvaluated { get; set; }

    [BinaryContent(Name = "WaitingTime", NodeType = BinaryContentTypes.Attribute)]
    public object WaitingTime { get; set; }

    [BinaryContent(Name = "TradeWaitingTime", NodeType = BinaryContentTypes.Attribute)]
    public object TradeWaitingTime { get; set; }

    [BinaryContent(Name = "QueueWaitingTime", NodeType = BinaryContentTypes.Attribute)]
    public object QueueWaitingTime { get; set; }

    [BinaryContent(Name = "RouteStatus", NodeType = BinaryContentTypes.Node)]
    public RouteStatus RouteStatus { get; set; }

    [BinaryContent(Name = "PlannedLoad", NodeType = BinaryContentTypes.Node)]
    public PlannedLoad PlannedLoad { get; set; }

    [BinaryContent(Name = "TradeDescription", NodeType = BinaryContentTypes.Node)]
    public TradeDescription TradeDescription { get; set; }

  }
}