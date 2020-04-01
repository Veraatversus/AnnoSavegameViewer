using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PassiveTrade {

    [BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
    public object AreaID { get; set; }

    [BinaryContent(Name = "BuysAllItems", NodeType = BinaryContentTypes.Attribute)]
    public object BuysAllItems { get; set; }

    [BinaryContent(Name = "BuysAllGoods", NodeType = BinaryContentTypes.Attribute)]
    public object BuysAllGoods { get; set; }

    [BinaryContent(Name = "OfferMap", NodeType = BinaryContentTypes.Node)]
    public OfferMap OfferMap { get; set; }

    [BinaryContent(Name = "History", NodeType = BinaryContentTypes.Node)]
    public PassiveTradeHistory History { get; set; }

    [BinaryContent(Name = "MinimumStock", NodeType = BinaryContentTypes.Node)]
    public MinimumStock MinimumStock { get; set; }

  }
}