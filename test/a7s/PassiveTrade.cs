using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class PassiveTrade {

[BinaryContent(Name = "OfferMap", NodeType = BinaryContentTypes.Node)]
public OfferMap OfferMap { get; set; }

[BinaryContent(Name = "History", NodeType = BinaryContentTypes.Node)]
public PassiveTradeHistory History { get; set; }

[BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
public HexString AreaID { get; set; }

[BinaryContent(Name = "MinimumStock", NodeType = BinaryContentTypes.Node)]
public MinimumStock MinimumStock { get; set; }

[BinaryContent(Name = "BuysAllItems", NodeType = BinaryContentTypes.Attribute)]
public HexString BuysAllItems { get; set; }

[BinaryContent(Name = "BuysAllGoods", NodeType = BinaryContentTypes.Attribute)]
public HexString BuysAllGoods { get; set; }

}
}
