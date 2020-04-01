using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PassiveTradeHistory {

    [BinaryContent(Name = "PassiveTradeEntries", NodeType = BinaryContentTypes.Node)]
    public PassiveTradeEntries PassiveTradeEntries { get; set; }

    [BinaryContent(Name = "TradeRouteEntries", NodeType = BinaryContentTypes.Node)]
    public TradeRouteEntries TradeRouteEntries { get; set; }

  }
}