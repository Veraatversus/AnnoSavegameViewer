namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class VisitorManager {

    [BinaryContent(Name = "AreaVisitorData", NodeType = BinaryContentTypes.Node)]
    public AreaVisitorData AreaVisitorData { get; set; }

    [BinaryContent(Name = "RouteMapping", NodeType = BinaryContentTypes.Node)]
    public RouteMapping RouteMapping { get; set; }

    [BinaryContent(Name = "ReceivedVisitors", NodeType = BinaryContentTypes.Node)]
    public ReceivedVisitors ReceivedVisitors { get; set; }

  }
}