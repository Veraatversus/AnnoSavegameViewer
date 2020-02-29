using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class NewspaperEventsListContext {

    [BinaryContent(Name = "ArticleGUID", NodeType = BinaryContentTypes.Attribute)]
    public object ArticleGUID { get; set; }

    [BinaryContent(Name = "TownID", NodeType = BinaryContentTypes.Attribute)]
    public object TownID { get; set; }

    [BinaryContent(Name = "TownName", NodeType = BinaryContentTypes.Attribute)]
    public object TownName { get; set; }

    [BinaryContent(Name = "ParticipantID", NodeType = BinaryContentTypes.Node)]
    public NewspaperEventsListContextParticipantID ParticipantID { get; set; }

    [BinaryContent(Name = "ObjectRef", NodeType = BinaryContentTypes.Node)]
    public NewspaperEventsListContextObjectRef ObjectRef { get; set; }

    [BinaryContent(Name = "Owner", NodeType = BinaryContentTypes.Node)]
    public NewspaperEventsListContextOwner Owner { get; set; }

  }
}