namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class StationsList {

    [BinaryContent(Name = "StationID", NodeType = BinaryContentTypes.Attribute)]
    public object StationID { get; set; }

    [BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
    public object AreaID { get; set; }

    [BinaryContent(Name = "VanishGoods", NodeType = BinaryContentTypes.Attribute)]
    public object VanishGoods { get; set; }

    [BinaryContent(Name = "TradeRouteID", NodeType = BinaryContentTypes.Attribute)]
    public object TradeRouteID { get; set; }

    [BinaryContent(Name = "HasTradeRights", NodeType = BinaryContentTypes.Attribute)]
    public object HasTradeRights { get; set; }

    [BinaryContent(Name = "ThrowGoodsOverboard", NodeType = BinaryContentTypes.Attribute)]
    public object ThrowGoodsOverboard { get; set; }

    [BinaryContent(Name = "WaitUntilFull", NodeType = BinaryContentTypes.Attribute)]
    public object WaitUntilFull { get; set; }

    [BinaryContent(Name = "WaitUntilEmpty", NodeType = BinaryContentTypes.Attribute)]
    public object WaitUntilEmpty { get; set; }

    [BinaryContent(Name = "GoodInfos", NodeType = BinaryContentTypes.Node)]
    public GoodInfos GoodInfos { get; set; }

    [BinaryContent(Name = "Waypoint", NodeType = BinaryContentTypes.Node)]
    public Waypoint Waypoint { get; set; }

    [BinaryContent(Name = "IDManager", NodeType = BinaryContentTypes.Node)]
    public StationsListIDManager IDManager { get; set; }

    [BinaryContent(Name = "RouteType", NodeType = BinaryContentTypes.Node)]
    public StationsListRouteType RouteType { get; set; }

    [BinaryContent(Name = "RouteOwner", NodeType = BinaryContentTypes.Node)]
    public RouteOwner RouteOwner { get; set; }

    [BinaryContent(Name = "AreaOwner", NodeType = BinaryContentTypes.Node)]
    public AreaOwner AreaOwner { get; set; }

  }
}