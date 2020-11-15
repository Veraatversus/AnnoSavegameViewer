namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class RouteWaypointsList {

    [BinaryContent(Name = "Area", NodeType = BinaryContentTypes.Attribute)]
    public object Area { get; set; }

    [BinaryContent(Name = "Time", NodeType = BinaryContentTypes.Attribute)]
    public object Time { get; set; }

    [BinaryContent(Name = "HarborPosition", NodeType = BinaryContentTypes.Attribute)]
    public object HarborPosition { get; set; }

    [BinaryContent(Name = "DurationMap", NodeType = BinaryContentTypes.Node)]
    public DurationMap DurationMap { get; set; }

  }
}