namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class ResourceBalance {

    [BinaryContent(Name = "Storage", NodeType = BinaryContentTypes.Attribute)]
    public object Storage { get; set; }

    [BinaryContent(Name = "OwnedGoods", NodeType = BinaryContentTypes.Node)]
    public OwnedGoods OwnedGoods { get; set; }

    [BinaryContent(Name = "EstimatedConstructionGoods", NodeType = BinaryContentTypes.Node)]
    public EstimatedConstructionGoods EstimatedConstructionGoods { get; set; }

    [BinaryContent(Name = "ConstructionMaterialUnlocks", NodeType = BinaryContentTypes.Node)]
    public ConstructionMaterialUnlocks ConstructionMaterialUnlocks { get; set; }

    [BinaryContent(Name = "AreaNeedUnlocks", NodeType = BinaryContentTypes.Node)]
    public AreaNeedUnlocks AreaNeedUnlocks { get; set; }

    [BinaryContent(Name = "Balance", NodeType = BinaryContentTypes.Node)]
    public ResourceBalanceBalance Balance { get; set; }

    [BinaryContent(Name = "SpecialStorage", NodeType = BinaryContentTypes.Node)]
    public SpecialStorage SpecialStorage { get; set; }

  }
}