using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class TradeRouteEntriesList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<TradeRouteEntriesListList> TradeRouteEntriesListList { get; set; }

  }
}