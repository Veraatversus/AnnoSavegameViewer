using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class WorkforceTransferManagerParticipantDataList {

    [BinaryContent(Name = "feedbackRoute", NodeType = BinaryContentTypes.Attribute)]
    public object FeedbackRoute { get; set; }

    [BinaryContent(Name = "feedbackDist", NodeType = BinaryContentTypes.Attribute)]
    public object FeedbackDist { get; set; }

    [BinaryContent(Name = "PaMSyTriggerSent", NodeType = BinaryContentTypes.Attribute)]
    public object PaMSyTriggerSent { get; set; }

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public WorkforceTransferManagerParticipantDataListValue Value { get; set; }

    [BinaryContent(Name = "owner", NodeType = BinaryContentTypes.Node)]
    public WorkforceTransferManagerParticipantDataListOwner Owner { get; set; }

    [BinaryContent(Name = "linkedAreas", NodeType = BinaryContentTypes.Node)]
    public LinkedAreas LinkedAreas { get; set; }

    [BinaryContent(Name = "feedbackShips", NodeType = BinaryContentTypes.Node)]
    public FeedbackShips FeedbackShips { get; set; }

    [BinaryContent(Name = "pathEstimations", NodeType = BinaryContentTypes.Node)]
    public PathEstimations PathEstimations { get; set; }

  }
}