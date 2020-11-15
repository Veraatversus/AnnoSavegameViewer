using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class PassiveTradeHistory {

[BinaryContent(Name = "PassiveTradeEntries", NodeType = BinaryContentTypes.Node)]
public PassiveTradeEntries PassiveTradeEntries { get; set; }

[BinaryContent(Name = "TradeRouteEntries", NodeType = BinaryContentTypes.Node)]
public TradeRouteEntries TradeRouteEntries { get; set; }

}
}
