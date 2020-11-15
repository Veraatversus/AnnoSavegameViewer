using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class SessionTradeRouteManager {

[BinaryContent(Name = "IDManager", NodeType = BinaryContentTypes.Node)]
public SessionTradeRouteManagerIDManager IDManager { get; set; }

[BinaryContent(Name = "RouteMap", NodeType = BinaryContentTypes.Node)]
public RouteMap RouteMap { get; set; }

}
}
