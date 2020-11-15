using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class DataBuffer {

[BinaryContent(Name = "sellGoods", NodeType = BinaryContentTypes.Node)]
public SellGoods SellGoods { get; set; }

[BinaryContent(Name = "buyGoods", NodeType = BinaryContentTypes.Node)]
public BuyGoods BuyGoods { get; set; }

[BinaryContent(Name = "shipPurposes", NodeType = BinaryContentTypes.Node)]
public ShipPurposes ShipPurposes { get; set; }

}
}
