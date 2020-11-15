using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class FeedbackController {

[BinaryContent(Name = "CurrentSequence", NodeType = BinaryContentTypes.Attribute)]
public HexString CurrentSequence { get; set; }

[BinaryContent(Name = "OverrideSequence", NodeType = BinaryContentTypes.Node)]
public OverrideSequence OverrideSequence { get; set; }

[BinaryContent(Name = "SequenceStartTime", NodeType = BinaryContentTypes.Attribute)]
public HexString SequenceStartTime { get; set; }

[BinaryContent(Name = "ForcedActorVariation", NodeType = BinaryContentTypes.Attribute)]
public HexString ForcedActorVariation { get; set; }

}
}
