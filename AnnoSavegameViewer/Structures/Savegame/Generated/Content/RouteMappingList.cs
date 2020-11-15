namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class RouteMappingList {

    [BinaryContent(Name = "ShipSpeed", NodeType = BinaryContentTypes.Attribute)]
    public object ShipSpeed { get; set; }

    [BinaryContent(Name = "MinUnloadingTime", NodeType = BinaryContentTypes.Attribute)]
    public object MinUnloadingTime { get; set; }

    [BinaryContent(Name = "IntervalDuration", NodeType = BinaryContentTypes.Attribute)]
    public object IntervalDuration { get; set; }

    [BinaryContent(Name = "ShipGUID", NodeType = BinaryContentTypes.Attribute)]
    public object ShipGUID { get; set; }

    [BinaryContent(Name = "Ships", NodeType = BinaryContentTypes.Node)]
    public RouteMappingListShips Ships { get; set; }

    [BinaryContent(Name = "RouteWaypoints", NodeType = BinaryContentTypes.Node)]
    public RouteWaypoints RouteWaypoints { get; set; }

  }
}