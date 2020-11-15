namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class RewardListList {

    [BinaryContent(Name = "Amount", NodeType = BinaryContentTypes.Attribute)]
    public object Amount { get; set; }

    [BinaryContent(Name = "AssetGUID", NodeType = BinaryContentTypes.Attribute)]
    public object AssetGUID { get; set; }

    [BinaryContent(Name = "SentToQuestArea", NodeType = BinaryContentTypes.Attribute)]
    public object SentToQuestArea { get; set; }

    [BinaryContent(Name = "IsDisguised", NodeType = BinaryContentTypes.Attribute)]
    public object IsDisguised { get; set; }

  }
}