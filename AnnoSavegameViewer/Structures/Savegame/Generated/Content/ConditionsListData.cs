using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ConditionsListData {

    #region Public Properties

    [BinaryContent(Name = "CorrespondingQuestID", NodeType = BinaryContentTypes.Attribute)]
    public object CorrespondingQuestID { get; set; }

    [BinaryContent(Name = "ClickedObjectID", NodeType = BinaryContentTypes.Attribute)]
    public object ClickedObjectID { get; set; }

    [BinaryContent(Name = "CollectorObjectID", NodeType = BinaryContentTypes.Attribute)]
    public object CollectorObjectID { get; set; }

    [BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Attribute)]
    public object QuestID { get; set; }

    [BinaryContent(Name = "TreasureGUID", NodeType = BinaryContentTypes.Attribute)]
    public object TreasureGUID { get; set; }

    [BinaryContent(Name = "EventGUID", NodeType = BinaryContentTypes.Attribute)]
    public object EventGUID { get; set; }

    [BinaryContent(Name = "SessionGUID", NodeType = BinaryContentTypes.Attribute)]
    public object SessionGUID { get; set; }

    [BinaryContent(Name = "IsNewSession", NodeType = BinaryContentTypes.Attribute)]
    public object IsNewSession { get; set; }

    [BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
    public object ID { get; set; }

    [BinaryContent(Name = "NotificationLabel", NodeType = BinaryContentTypes.Attribute)]
    public object NotificationLabel { get; set; }

    [BinaryContent(Name = "CorrespondingObjectGUID", NodeType = BinaryContentTypes.Node)]
    public CorrespondingObjectGUID CorrespondingObjectGUID { get; set; }

    #endregion Public Properties
  }
}