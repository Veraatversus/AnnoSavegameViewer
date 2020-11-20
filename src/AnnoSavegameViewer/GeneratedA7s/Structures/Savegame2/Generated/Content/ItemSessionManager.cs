namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class ItemSessionManager {

    [BinaryContent(Name = "ItemIdCounter", NodeType = BinaryContentTypes.Attribute)]
    public object ItemIdCounter { get; set; }

    [BinaryContent(Name = "BuffFluffIndex", NodeType = BinaryContentTypes.Attribute)]
    public object BuffFluffIndex { get; set; }

    [BinaryContent(Name = "TimeWhenBuffFluffIndexIncrease", NodeType = BinaryContentTypes.Attribute)]
    public object TimeWhenBuffFluffIndexIncrease { get; set; }

    [BinaryContent(Name = "ItemMap", NodeType = BinaryContentTypes.Node)]
    public ItemMap ItemMap { get; set; }

    [BinaryContent(Name = "ProductItem", NodeType = BinaryContentTypes.Node)]
    public ProductItem ProductItem { get; set; }

    [BinaryContent(Name = "SetBuffs", NodeType = BinaryContentTypes.Node)]
    public SetBuffs SetBuffs { get; set; }

    [BinaryContent(Name = "AdditionalAreaEffects", NodeType = BinaryContentTypes.Node)]
    public AdditionalAreaEffects AdditionalAreaEffects { get; set; }

    [BinaryContent(Name = "AdditionalSessionEffects", NodeType = BinaryContentTypes.Node)]
    public AdditionalSessionEffects AdditionalSessionEffects { get; set; }

    [BinaryContent(Name = "TrackedPaths", NodeType = BinaryContentTypes.Node)]
    public TrackedPaths TrackedPaths { get; set; }

    [BinaryContent(Name = "DynamicRangeSources", NodeType = BinaryContentTypes.Node)]
    public DynamicRangeSources DynamicRangeSources { get; set; }
  }
}