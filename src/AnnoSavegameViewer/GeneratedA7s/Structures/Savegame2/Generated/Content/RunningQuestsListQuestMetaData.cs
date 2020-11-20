namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class RunningQuestsListQuestMetaData {

    [BinaryContent(Name = "QuestArea", NodeType = BinaryContentTypes.Attribute)]
    public object QuestArea { get; set; }

    [BinaryContent(Name = "RelatedQuestGUID", NodeType = BinaryContentTypes.Attribute)]
    public object RelatedQuestGUID { get; set; }

  }
}