using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ConditionsListObjectFilter {

    #region Public Properties

    [BinaryContent(Name = "ObjectGUID", NodeType = BinaryContentTypes.Attribute)]
    public object ObjectGUID { get; set; }

    [BinaryContent(Name = "CheckParticipantID", NodeType = BinaryContentTypes.Attribute)]
    public object CheckParticipantID { get; set; }

    [BinaryContent(Name = "UseProcessingParticipantID", NodeType = BinaryContentTypes.Attribute)]
    public object UseProcessingParticipantID { get; set; }

    [BinaryContent(Name = "ObjectParticipant", NodeType = BinaryContentTypes.Node)]
    public ConditionsListObjectFilterObjectParticipant ObjectParticipant { get; set; }

    [BinaryContent(Name = "IslandNames", NodeType = BinaryContentTypes.Node)]
    public ConditionsListObjectFilterIslandNames IslandNames { get; set; }

    [BinaryContent(Name = "SessionGUID", NodeType = BinaryContentTypes.Node)]
    public ConditionsListObjectFilterSessionGUID SessionGUID { get; set; }

    [BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Node)]
    public ConditionsListObjectFilterQuestID QuestID { get; set; }

    #endregion Public Properties
  }
}