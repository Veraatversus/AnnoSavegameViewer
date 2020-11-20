namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class TradeRouteEntriesList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<TradeRouteEntriesListList> TradeRouteEntriesListList { get; set; }

  }
}