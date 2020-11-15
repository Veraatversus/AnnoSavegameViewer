namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class GlobalBalance {

    [BinaryContent(Name = "RubberbandFactor", NodeType = BinaryContentTypes.Attribute)]
    public object RubberbandFactor { get; set; }

    [BinaryContent(Name = "LastBalanceUpdate", NodeType = BinaryContentTypes.Attribute)]
    public object LastBalanceUpdate { get; set; }

    [BinaryContent(Name = "LastGoodsUpdate", NodeType = BinaryContentTypes.Attribute)]
    public object LastGoodsUpdate { get; set; }

    [BinaryContent(Name = "MoneyDelta", NodeType = BinaryContentTypes.Node)]
    public MoneyDelta MoneyDelta { get; set; }

    [BinaryContent(Name = "OtherRegionDeltas", NodeType = BinaryContentTypes.Node)]
    public OtherRegionDeltas OtherRegionDeltas { get; set; }

    [BinaryContent(Name = "Balance0", NodeType = BinaryContentTypes.Node)]
    public Balance0 Balance0 { get; set; }
  }
}