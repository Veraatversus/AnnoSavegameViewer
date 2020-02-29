using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class QueuedTransfersList {

    [BinaryContent(Name = "TransferID", NodeType = BinaryContentTypes.Attribute)]
    public object TransferID { get; set; }

    [BinaryContent(Name = "SourceSessionGUID", NodeType = BinaryContentTypes.Attribute)]
    public object SourceSessionGUID { get; set; }

    [BinaryContent(Name = "TargetSessionGUID", NodeType = BinaryContentTypes.Attribute)]
    public object TargetSessionGUID { get; set; }

    [BinaryContent(Name = "TargetGameObject", NodeType = BinaryContentTypes.Attribute)]
    public object TargetGameObject { get; set; }

    [BinaryContent(Name = "TravelTimeLeft", NodeType = BinaryContentTypes.Attribute)]
    public object TravelTimeLeft { get; set; }

    [BinaryContent(Name = "TotalTravelTime", NodeType = BinaryContentTypes.Attribute)]
    public object TotalTravelTime { get; set; }

    [BinaryContent(Name = "TargetPosition", NodeType = BinaryContentTypes.Attribute)]
    public object TargetPosition { get; set; }

    [BinaryContent(Name = "TargetDirection", NodeType = BinaryContentTypes.Attribute)]
    public object TargetDirection { get; set; }

    [BinaryContent(Name = "GroupID", NodeType = BinaryContentTypes.Attribute)]
    public object GroupID { get; set; }

    [BinaryContent(Name = "State", NodeType = BinaryContentTypes.Node)]
    public QueuedTransfersListState State { get; set; }

  }
}