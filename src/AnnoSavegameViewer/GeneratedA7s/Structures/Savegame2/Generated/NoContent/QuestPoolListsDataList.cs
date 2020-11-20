namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class QuestPoolListsDataList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public QuestPoolListsDataListValue Value { get; set; }

    [BinaryContent(Name = "OwnerID", NodeType = BinaryContentTypes.Node)]
    public OwnerID OwnerID { get; set; }

    [BinaryContent(Name = "QuestLatencies", NodeType = BinaryContentTypes.Node)]
    public QuestLatencies QuestLatencies { get; set; }

    [BinaryContent(Name = "QuestDelays", NodeType = BinaryContentTypes.Node)]
    public QuestDelays QuestDelays { get; set; }

    [BinaryContent(Name = "QuestPriorities", NodeType = BinaryContentTypes.Node)]
    public QuestPriorities QuestPriorities { get; set; }

    [BinaryContent(Name = "QuestLineProgress", NodeType = BinaryContentTypes.Node)]
    public QuestLineProgress QuestLineProgress { get; set; }

    [BinaryContent(Name = "QuestPools", NodeType = BinaryContentTypes.Node)]
    public QuestPools QuestPools { get; set; }

  }
}