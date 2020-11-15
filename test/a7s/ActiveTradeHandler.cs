using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ActiveTradeHandler {

[BinaryContent(Name = "ships", NodeType = BinaryContentTypes.Node)]
public ActiveTradeHandlerShips Ships { get; set; }

[BinaryContent(Name = "lastVisited", NodeType = BinaryContentTypes.Node)]
public LastVisited LastVisited { get; set; }

[BinaryContent(Name = "RequestedShips", NodeType = BinaryContentTypes.Node)]
public RequestedShips RequestedShips { get; set; }

}
}
