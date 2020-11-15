using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class VisitorManager {

[BinaryContent(Name = "AreaVisitorData", NodeType = BinaryContentTypes.Node)]
public AreaVisitorData AreaVisitorData { get; set; }

[BinaryContent(Name = "RouteMapping", NodeType = BinaryContentTypes.Node)]
public RouteMapping RouteMapping { get; set; }

[BinaryContent(Name = "ReceivedVisitors", NodeType = BinaryContentTypes.Node)]
public ReceivedVisitors ReceivedVisitors { get; set; }

}
}
