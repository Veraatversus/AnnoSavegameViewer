using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class Trader {

[BinaryContent(Name = "offeredItems", NodeType = BinaryContentTypes.Node)]
public OfferedItems OfferedItems { get; set; }

[BinaryContent(Name = "productGain", NodeType = BinaryContentTypes.Node)]
public ProductGain ProductGain { get; set; }

[BinaryContent(Name = "nextProductionType", NodeType = BinaryContentTypes.Node)]
public NextProductionType NextProductionType { get; set; }

[BinaryContent(Name = "tradeRouteID", NodeType = BinaryContentTypes.Attribute)]
public HexString TradeRouteID { get; set; }

[BinaryContent(Name = "warships", NodeType = BinaryContentTypes.Node)]
public Warships Warships { get; set; }

[BinaryContent(Name = "tradeships", NodeType = BinaryContentTypes.Node)]
public TraderTradeships Tradeships { get; set; }

[BinaryContent(Name = "sellships", NodeType = BinaryContentTypes.Node)]
public Sellships Sellships { get; set; }

[BinaryContent(Name = "sellCooldowns", NodeType = BinaryContentTypes.Attribute)]
public HexString SellCooldowns { get; set; }

[BinaryContent(Name = "rerollTimer", NodeType = BinaryContentTypes.Attribute)]
public HexString RerollTimer { get; set; }

[BinaryContent(Name = "lastShipProduction", NodeType = BinaryContentTypes.Attribute)]
public HexString LastShipProduction { get; set; }

[BinaryContent(Name = "replacementOffers", NodeType = BinaryContentTypes.Node)]
public ReplacementOffers ReplacementOffers { get; set; }

}
}
