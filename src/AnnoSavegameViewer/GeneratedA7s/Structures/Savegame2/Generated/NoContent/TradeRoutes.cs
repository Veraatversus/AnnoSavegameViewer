namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class TradeRoutes {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<TradeRoutesList> TradeRoutesList { get; set; }

  }
}