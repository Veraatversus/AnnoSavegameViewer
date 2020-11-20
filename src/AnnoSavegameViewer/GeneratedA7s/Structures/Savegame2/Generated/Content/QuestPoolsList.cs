namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class QuestPoolsList {

    [BinaryContent(Name = "questPoolGUID", NodeType = BinaryContentTypes.Attribute)]
    public object QuestPoolGUID { get; set; }

    [BinaryContent(Name = "IsEnabled", NodeType = BinaryContentTypes.Attribute)]
    public object IsEnabled { get; set; }

    [BinaryContent(Name = "OptionalCooldownTimestamp", NodeType = BinaryContentTypes.Node)]
    public OptionalCooldownTimestamp OptionalCooldownTimestamp { get; set; }

    [BinaryContent(Name = "QuestBlockings", NodeType = BinaryContentTypes.Node)]
    public QuestBlockings QuestBlockings { get; set; }

  }
}