using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ActionListFailureList {

    [BinaryContent(Name = "AssetGUID", NodeType = BinaryContentTypes.Attribute)]
    public object AssetGUID { get; set; }

    [BinaryContent(Name = "ActionID", NodeType = BinaryContentTypes.Attribute)]
    public object ActionID { get; set; }

    [BinaryContent(Name = "actionType", NodeType = BinaryContentTypes.Node)]
    public ActionListFailureListActionType ActionType { get; set; }

    [BinaryContent(Name = "OwnerParticipant", NodeType = BinaryContentTypes.Node)]
    public ActionListFailureListOwnerParticipant OwnerParticipant { get; set; }

    [BinaryContent(Name = "TargetPeer", NodeType = BinaryContentTypes.Node)]
    public ActionListFailureListTargetPeer TargetPeer { get; set; }

  }
}