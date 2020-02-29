using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class TradeRoutes {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<TradeRoutesList> TradeRoutesList { get; set; }

  }
}