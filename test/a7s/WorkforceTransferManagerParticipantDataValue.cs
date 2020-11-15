using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class WorkforceTransferManagerParticipantDataValue {

[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
public WorkforceTransferManagerParticipantDataValuesNoneValue Value { get; set; }

[BinaryContent(Name = "owner", NodeType = BinaryContentTypes.Node)]
public ParticipantDataValuesNoneOwner Owner { get; set; }

[BinaryContent(Name = "linkedAreas", NodeType = BinaryContentTypes.Node)]
public LinkedAreas LinkedAreas { get; set; }

[BinaryContent(Name = "feedbackRoute", NodeType = BinaryContentTypes.Attribute)]
public HexString FeedbackRoute { get; set; }

[BinaryContent(Name = "feedbackShips", NodeType = BinaryContentTypes.Node)]
public FeedbackShips FeedbackShips { get; set; }

[BinaryContent(Name = "pathEstimations", NodeType = BinaryContentTypes.Node)]
public PathEstimations PathEstimations { get; set; }

}
}
