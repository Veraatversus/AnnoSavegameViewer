using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class FeedbackController {

    [BinaryContent(Name = "CurrentSequence", NodeType = BinaryContentTypes.Attribute)]
    public object CurrentSequence { get; set; }

    [BinaryContent(Name = "SequenceStartTime", NodeType = BinaryContentTypes.Attribute)]
    public object SequenceStartTime { get; set; }

    [BinaryContent(Name = "IsFeedbackEnabled", NodeType = BinaryContentTypes.Attribute)]
    public object IsFeedbackEnabled { get; set; }

    [BinaryContent(Name = "ForcedActorVariation", NodeType = BinaryContentTypes.Attribute)]
    public object ForcedActorVariation { get; set; }

    [BinaryContent(Name = "OverrideSequence", NodeType = BinaryContentTypes.Node)]
    public OverrideSequence OverrideSequence { get; set; }

  }
}