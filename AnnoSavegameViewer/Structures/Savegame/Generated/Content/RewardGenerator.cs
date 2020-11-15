namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class RewardGenerator {

    [BinaryContent(Name = "IsOptionalQuest", NodeType = BinaryContentTypes.Attribute)]
    public object IsOptionalQuest { get; set; }

    [BinaryContent(Name = "RewardList", NodeType = BinaryContentTypes.Node)]
    public RewardList RewardList { get; set; }

    [BinaryContent(Name = "QuestDifficulty", NodeType = BinaryContentTypes.Node)]
    public QuestDifficulty QuestDifficulty { get; set; }

    [BinaryContent(Name = "ExpeditionDifficulty", NodeType = BinaryContentTypes.Node)]
    public ExpeditionDifficulty ExpeditionDifficulty { get; set; }

    [BinaryContent(Name = "ExpeditionRegion", NodeType = BinaryContentTypes.Node)]
    public ExpeditionRegion ExpeditionRegion { get; set; }

  }
}