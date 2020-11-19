namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class QuestManager {

    [BinaryContent(Name = "QuestPoolLists", NodeType = BinaryContentTypes.Node)]
    public QuestPoolLists QuestPoolLists { get; set; }

    [BinaryContent(Name = "DisabledQuests", NodeType = BinaryContentTypes.Node)]
    public DisabledQuests DisabledQuests { get; set; }

    [BinaryContent(Name = "RunningQuests", NodeType = BinaryContentTypes.Node)]
    public RunningQuests RunningQuests { get; set; }

    [BinaryContent(Name = "QuestHistory", NodeType = BinaryContentTypes.Node)]
    public QuestHistory QuestHistory { get; set; }

    [BinaryContent(Name = "QuestInstanceFactory", NodeType = BinaryContentTypes.Node)]
    public QuestInstanceFactory QuestInstanceFactory { get; set; }

  }
}