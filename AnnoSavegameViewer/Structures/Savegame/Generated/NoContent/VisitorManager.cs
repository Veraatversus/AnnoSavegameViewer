using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class VisitorManager {

    [BinaryContent(Name = "AreaVisitorData", NodeType = BinaryContentTypes.Node)]
    public AreaVisitorData AreaVisitorData { get; set; }

    [BinaryContent(Name = "RouteMapping", NodeType = BinaryContentTypes.Node)]
    public RouteMapping RouteMapping { get; set; }

    [BinaryContent(Name = "ReceivedVisitors", NodeType = BinaryContentTypes.Node)]
    public ReceivedVisitors ReceivedVisitors { get; set; }

  }
}