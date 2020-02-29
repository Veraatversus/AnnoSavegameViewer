using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DataBuffer {

    [BinaryContent(Name = "sellGoods", NodeType = BinaryContentTypes.Node)]
    public SellGoods SellGoods { get; set; }

    [BinaryContent(Name = "buyGoods", NodeType = BinaryContentTypes.Node)]
    public BuyGoods BuyGoods { get; set; }

    [BinaryContent(Name = "shipPurposes", NodeType = BinaryContentTypes.Node)]
    public ShipPurposes ShipPurposes { get; set; }

  }
}