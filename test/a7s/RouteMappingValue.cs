using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class RouteMappingValue {

[BinaryContent(Name = "ShipSpeed", NodeType = BinaryContentTypes.Attribute)]
public HexString ShipSpeed { get; set; }

[BinaryContent(Name = "MinUnloadingTime", NodeType = BinaryContentTypes.Attribute)]
public HexString MinUnloadingTime { get; set; }

[BinaryContent(Name = "IntervalDuration", NodeType = BinaryContentTypes.Attribute)]
public HexString IntervalDuration { get; set; }

[BinaryContent(Name = "Ships", NodeType = BinaryContentTypes.Node)]
public NoneShips Ships { get; set; }

[BinaryContent(Name = "RouteWaypoints", NodeType = BinaryContentTypes.Node)]
public RouteWaypoints RouteWaypoints { get; set; }

[BinaryContent(Name = "ShipGUID", NodeType = BinaryContentTypes.Attribute)]
public HexString ShipGUID { get; set; }

}
}
