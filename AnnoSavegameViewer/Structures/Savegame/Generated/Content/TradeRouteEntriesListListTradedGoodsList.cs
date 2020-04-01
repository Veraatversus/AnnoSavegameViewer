using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class TradeRouteEntriesListListTradedGoodsList {

    [BinaryContent(Name = "GoodGuid", NodeType = BinaryContentTypes.Attribute)]
    public object GoodGuid { get; set; }

    [BinaryContent(Name = "GoodAmount", NodeType = BinaryContentTypes.Attribute)]
    public object GoodAmount { get; set; }

  }
}