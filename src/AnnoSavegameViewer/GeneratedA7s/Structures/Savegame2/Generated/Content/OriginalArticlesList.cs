namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class OriginalArticlesList {

    [BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
    public object ID { get; set; }

    [BinaryContent(Name = "Priority", NodeType = BinaryContentTypes.Attribute)]
    public object Priority { get; set; }

    [BinaryContent(Name = "IsUsedForNewspaper", NodeType = BinaryContentTypes.Attribute)]
    public object IsUsedForNewspaper { get; set; }

    [BinaryContent(Name = "Size", NodeType = BinaryContentTypes.Node)]
    public Size Size { get; set; }

    [BinaryContent(Name = "Context", NodeType = BinaryContentTypes.Node)]
    public Context Context { get; set; }

  }
}