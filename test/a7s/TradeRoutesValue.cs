using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class TradeRoutesValue {

[BinaryContent(Name = "TransportTasks", NodeType = BinaryContentTypes.Node)]
public NoneTransportTasks TransportTasks { get; set; }

[BinaryContent(Name = "Route", NodeType = BinaryContentTypes.Attribute)]
public HexString Route { get; set; }

[BinaryContent(Name = "RoundTravel", NodeType = BinaryContentTypes.Attribute)]
public HexString RoundTravel { get; set; }

[BinaryContent(Name = "ShipID", NodeType = BinaryContentTypes.Attribute)]
public HexString ShipID { get; set; }

[BinaryContent(Name = "RouteType", NodeType = BinaryContentTypes.Node)]
public NoneRouteType RouteType { get; set; }

[BinaryContent(Name = "EstablishTime", NodeType = BinaryContentTypes.Attribute)]
public HexString EstablishTime { get; set; }

}
}
