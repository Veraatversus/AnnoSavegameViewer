using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class TradeShips {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<TradeShipsList> TradeShipsList { get; set; }

  }
}