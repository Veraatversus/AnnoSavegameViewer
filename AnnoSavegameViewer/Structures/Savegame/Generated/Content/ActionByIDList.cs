using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ActionByIDList {

    #region Public Properties

    [BinaryContent(Name = "actionID", NodeType = BinaryContentTypes.Attribute)]
    public object ActionID1 { get; set; }

    [BinaryContent(Name = "UseVariableAsDelay", NodeType = BinaryContentTypes.Attribute)]
    public object UseVariableAsDelay { get; set; }

    [BinaryContent(Name = "QuestID", NodeType = BinaryContentTypes.Attribute)]
    public object QuestID { get; set; }

    [BinaryContent(Name = "AssetGUID", NodeType = BinaryContentTypes.Attribute)]
    public object AssetGUID { get; set; }

    [BinaryContent(Name = "ActionID", NodeType = BinaryContentTypes.Attribute)]
    public object ActionID2 { get; set; }

    [BinaryContent(Name = "actionType", NodeType = BinaryContentTypes.Node)]
    public ActionType ActionType { get; set; }

    [BinaryContent(Name = "DelayVariable", NodeType = BinaryContentTypes.Node)]
    public DelayVariable DelayVariable { get; set; }

    [BinaryContent(Name = "OwnerParticipant", NodeType = BinaryContentTypes.Node)]
    public OwnerParticipant OwnerParticipant { get; set; }

    [BinaryContent(Name = "TargetPeer", NodeType = BinaryContentTypes.Node)]
    public ActionByIDListTargetPeer TargetPeer { get; set; }

    [BinaryContent(Name = "QuestMetaData", NodeType = BinaryContentTypes.Node)]
    public QuestMetaData QuestMetaData { get; set; }

    [BinaryContent(Name = "DelayedActions", NodeType = BinaryContentTypes.Node)]
    public DelayedActions DelayedActions { get; set; }

    #endregion Public Properties
  }
}