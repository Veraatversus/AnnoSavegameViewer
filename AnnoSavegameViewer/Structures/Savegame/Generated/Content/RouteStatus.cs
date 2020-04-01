using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class RouteStatus {

    [BinaryContent(Name = "RouteStatus", NodeType = BinaryContentTypes.Attribute)]
    public object RouteStatusItem { get; set; }

  }
}