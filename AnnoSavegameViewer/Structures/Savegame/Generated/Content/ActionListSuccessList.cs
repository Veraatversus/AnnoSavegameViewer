using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ActionListSuccessList {

    [BinaryContent(Name = "Quest", NodeType = BinaryContentTypes.Attribute)]
    public object Quest { get; set; }

    [BinaryContent(Name = "QuestSession", NodeType = BinaryContentTypes.Attribute)]
    public object QuestSession { get; set; }

    [BinaryContent(Name = "AssetGUID", NodeType = BinaryContentTypes.Attribute)]
    public object AssetGUID { get; set; }

    [BinaryContent(Name = "ActionID", NodeType = BinaryContentTypes.Attribute)]
    public object ActionID { get; set; }

    [BinaryContent(Name = "ShowPamsyMessage", NodeType = BinaryContentTypes.Attribute)]
    public object ShowPamsyMessage { get; set; }

    [BinaryContent(Name = "Articles", NodeType = BinaryContentTypes.Attribute)]
    public object Articles { get; set; }

    [BinaryContent(Name = "PictureArea", NodeType = BinaryContentTypes.Attribute)]
    public object PictureArea { get; set; }

    [BinaryContent(Name = "actionType", NodeType = BinaryContentTypes.Node)]
    public ActionListSuccessListActionType ActionType { get; set; }

    [BinaryContent(Name = "OwnerParticipant", NodeType = BinaryContentTypes.Node)]
    public ActionListSuccessListOwnerParticipant OwnerParticipant { get; set; }

    [BinaryContent(Name = "TargetPeer", NodeType = BinaryContentTypes.Node)]
    public ActionListSuccessListTargetPeer TargetPeer { get; set; }

    [BinaryContent(Name = "OpenNewspaperType", NodeType = BinaryContentTypes.Node)]
    public OpenNewspaperType OpenNewspaperType { get; set; }

  }
}