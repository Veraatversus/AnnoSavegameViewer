using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

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

    [BinaryContent(Name = "SessionBuffs", NodeType = BinaryContentTypes.Node)]
    public SessionBuffs SessionBuffs { get; set; }

    [BinaryContent(Name = "AreaBuffs", NodeType = BinaryContentTypes.Node)]
    public AreaBuffs AreaBuffs { get; set; }

  }
}