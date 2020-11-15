namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class Context {

    [BinaryContent(Name = "ArticleGUID", NodeType = BinaryContentTypes.Attribute)]
    public object ArticleGUID { get; set; }

    [BinaryContent(Name = "TownID", NodeType = BinaryContentTypes.Attribute)]
    public object TownID { get; set; }

    [BinaryContent(Name = "ParticipantName", NodeType = BinaryContentTypes.Attribute)]
    public object ParticipantName { get; set; }

    [BinaryContent(Name = "TownName", NodeType = BinaryContentTypes.Attribute)]
    public object TownName { get; set; }

    [BinaryContent(Name = "ObjectGUID", NodeType = BinaryContentTypes.Attribute)]
    public object ObjectGUID { get; set; }

    [BinaryContent(Name = "ObjectName", NodeType = BinaryContentTypes.Attribute)]
    public object ObjectName { get; set; }

    [BinaryContent(Name = "ParticipantID", NodeType = BinaryContentTypes.Node)]
    public ContextParticipantID ParticipantID { get; set; }

    [BinaryContent(Name = "ObjectRef", NodeType = BinaryContentTypes.Node)]
    public ObjectRef ObjectRef { get; set; }

    [BinaryContent(Name = "Owner", NodeType = BinaryContentTypes.Node)]
    public ContextOwner Owner { get; set; }
  }
}