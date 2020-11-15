namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class ReplacementArticlesListContext {

    [BinaryContent(Name = "ArticleGUID", NodeType = BinaryContentTypes.Attribute)]
    public object ArticleGUID { get; set; }

    [BinaryContent(Name = "TownID", NodeType = BinaryContentTypes.Attribute)]
    public object TownID { get; set; }

    [BinaryContent(Name = "ParticipantID", NodeType = BinaryContentTypes.Node)]
    public ReplacementArticlesListContextParticipantID ParticipantID { get; set; }

    [BinaryContent(Name = "ObjectRef", NodeType = BinaryContentTypes.Node)]
    public ReplacementArticlesListContextObjectRef ObjectRef { get; set; }

    [BinaryContent(Name = "Owner", NodeType = BinaryContentTypes.Node)]
    public ReplacementArticlesListContextOwner Owner { get; set; }

  }
}