using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class PropertyTradeRouteVehicle {

[BinaryContent(Name = "RouteStatus", NodeType = BinaryContentTypes.Node)]
public RouteStatus RouteStatus { get; set; }

[BinaryContent(Name = "TradeRouteID", NodeType = BinaryContentTypes.Attribute)]
public HexString TradeRouteID { get; set; }

[BinaryContent(Name = "TargetStationID", NodeType = BinaryContentTypes.Attribute)]
public HexString TargetStationID { get; set; }

[BinaryContent(Name = "TargetBuildingID", NodeType = BinaryContentTypes.Attribute)]
public HexString TargetBuildingID { get; set; }

[BinaryContent(Name = "HarbourEvaluated", NodeType = BinaryContentTypes.Attribute)]
public HexString HarbourEvaluated { get; set; }

[BinaryContent(Name = "TargetLoadingHarbour", NodeType = BinaryContentTypes.Attribute)]
public HexString TargetLoadingHarbour { get; set; }

[BinaryContent(Name = "PlannedLoad", NodeType = BinaryContentTypes.Node)]
public PlannedLoad PlannedLoad { get; set; }

[BinaryContent(Name = "TradeDescription", NodeType = BinaryContentTypes.Node)]
public TradeDescription TradeDescription { get; set; }

[BinaryContent(Name = "WaitingTime", NodeType = BinaryContentTypes.Attribute)]
public HexString WaitingTime { get; set; }

[BinaryContent(Name = "ForceUpdateMovement", NodeType = BinaryContentTypes.Attribute)]
public HexString ForceUpdateMovement { get; set; }

}
}
