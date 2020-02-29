using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PassiveTradeEntriesListListTradedGoods {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<PassiveTradeEntriesListListTradedGoodsList> PassiveTradeEntriesListListTradedGoodsList { get; set; }

  }
}