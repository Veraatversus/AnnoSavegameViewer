using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ActiveTradeHandler {

    [BinaryContent(Name = "ships", NodeType = BinaryContentTypes.Node)]
    public ActiveTradeHandlerShips Ships { get; set; }

    [BinaryContent(Name = "lastVisited", NodeType = BinaryContentTypes.Node)]
    public LastVisited LastVisited { get; set; }

    [BinaryContent(Name = "RequestedShips", NodeType = BinaryContentTypes.Node)]
    public RequestedShips RequestedShips { get; set; }

  }
}