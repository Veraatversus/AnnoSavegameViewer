using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class TradeRouteEntriesListListTradedGoods {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<TradeRouteEntriesListListTradedGoodsList> TradeRouteEntriesListListTradedGoodsList { get; set; }

  }
}