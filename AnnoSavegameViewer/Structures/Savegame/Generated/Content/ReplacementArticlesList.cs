using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ReplacementArticlesList {

    [BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
    public object ID { get; set; }

    [BinaryContent(Name = "IsUsedForNewspaper", NodeType = BinaryContentTypes.Attribute)]
    public object IsUsedForNewspaper { get; set; }

    [BinaryContent(Name = "Size", NodeType = BinaryContentTypes.Node)]
    public ReplacementArticlesListSize Size { get; set; }

    [BinaryContent(Name = "Context", NodeType = BinaryContentTypes.Node)]
    public ReplacementArticlesListContext Context { get; set; }

  }
}