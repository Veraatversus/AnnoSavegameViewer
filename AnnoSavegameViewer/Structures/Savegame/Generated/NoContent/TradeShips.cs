namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class TradeShips {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<TradeShipsList> TradeShipsList { get; set; }

  }
}