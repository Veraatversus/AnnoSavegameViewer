using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class TradeRouteEntriesValuesNoneValue {

[BinaryContent(Name = "Trader", NodeType = BinaryContentTypes.Node)]
public NoneTrader Trader { get; set; }

[BinaryContent(Name = "TradedGoods", NodeType = BinaryContentTypes.Node)]
public TradedGoods TradedGoods { get; set; }

[BinaryContent(Name = "TraderShip", NodeType = BinaryContentTypes.Attribute)]
public HexString TraderShip { get; set; }

[BinaryContent(Name = "ExecutionTime", NodeType = BinaryContentTypes.Attribute)]
public HexString ExecutionTime { get; set; }

[BinaryContent(Name = "Finalized", NodeType = BinaryContentTypes.Attribute)]
public HexString Finalized { get; set; }

[BinaryContent(Name = "RouteID", NodeType = BinaryContentTypes.Attribute)]
public HexString RouteID { get; set; }

[BinaryContent(Name = "RouteName", NodeType = BinaryContentTypes.Attribute)]
public HexString RouteName { get; set; }

}
}
