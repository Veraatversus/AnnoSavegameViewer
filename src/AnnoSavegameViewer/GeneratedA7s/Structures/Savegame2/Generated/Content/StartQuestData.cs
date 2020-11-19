namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class StartQuestData {

    [BinaryContent(Name = "QuestLineGUID", NodeType = BinaryContentTypes.Attribute)]
    public object QuestLineGUID { get; set; }

    [BinaryContent(Name = "TriggeringChain", NodeType = BinaryContentTypes.Attribute)]
    public object TriggeringChain { get; set; }

    [BinaryContent(Name = "MetaData", NodeType = BinaryContentTypes.Node)]
    public MetaData MetaData { get; set; }

  }
}