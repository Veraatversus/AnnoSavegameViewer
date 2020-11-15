using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class StationsValue {

[BinaryContent(Name = "StationID", NodeType = BinaryContentTypes.Attribute)]
public HexString StationID { get; set; }

[BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
public HexString AreaID { get; set; }

[BinaryContent(Name = "GoodInfos", NodeType = BinaryContentTypes.Node)]
public GoodInfos GoodInfos { get; set; }

[BinaryContent(Name = "Waypoint", NodeType = BinaryContentTypes.Node)]
public Waypoint Waypoint { get; set; }

[BinaryContent(Name = "VanishGoods", NodeType = BinaryContentTypes.Attribute)]
public HexString VanishGoods { get; set; }

[BinaryContent(Name = "TradeRouteID", NodeType = BinaryContentTypes.Attribute)]
public HexString TradeRouteID { get; set; }

[BinaryContent(Name = "IDManager", NodeType = BinaryContentTypes.Node)]
public ValuesNoneIDManager IDManager { get; set; }

[BinaryContent(Name = "RouteType", NodeType = BinaryContentTypes.Node)]
public RouteType RouteType { get; set; }

[BinaryContent(Name = "RouteOwner", NodeType = BinaryContentTypes.Node)]
public RouteOwner RouteOwner { get; set; }

[BinaryContent(Name = "AreaOwner", NodeType = BinaryContentTypes.Node)]
public AreaOwner AreaOwner { get; set; }

[BinaryContent(Name = "HasTradeRights", NodeType = BinaryContentTypes.Attribute)]
public HexString HasTradeRights { get; set; }

[BinaryContent(Name = "ThrowGoodsOverboard", NodeType = BinaryContentTypes.Attribute)]
public HexString ThrowGoodsOverboard { get; set; }

[BinaryContent(Name = "WaitUntilEmpty", NodeType = BinaryContentTypes.Attribute)]
public HexString WaitUntilEmpty { get; set; }

[BinaryContent(Name = "WaitUntilFull", NodeType = BinaryContentTypes.Attribute)]
public HexString WaitUntilFull { get; set; }

}
}
