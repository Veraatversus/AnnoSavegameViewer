namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class WaypointsList {

    [BinaryContent(Name = "TravelTime", NodeType = BinaryContentTypes.Attribute)]
    public object TravelTime { get; set; }

    [BinaryContent(Name = "ArrivalTime", NodeType = BinaryContentTypes.Attribute)]
    public object ArrivalTime { get; set; }

    [BinaryContent(Name = "IsHandled", NodeType = BinaryContentTypes.Attribute)]
    public object IsHandled { get; set; }

    [BinaryContent(Name = "TargetObject", NodeType = BinaryContentTypes.Node)]
    public TargetObject TargetObject { get; set; }

    [BinaryContent(Name = "Orders", NodeType = BinaryContentTypes.Node)]
    public Orders Orders { get; set; }

    [BinaryContent(Name = "Owner", NodeType = BinaryContentTypes.Node)]
    public WaypointsListOwner Owner { get; set; }

  }
}