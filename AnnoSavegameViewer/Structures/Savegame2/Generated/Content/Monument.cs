namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class Monument {

    [BinaryContent(Name = "EventState", NodeType = BinaryContentTypes.Attribute)]
    public object EventState { get; set; }

    [BinaryContent(Name = "eventAttractiveness", NodeType = BinaryContentTypes.Attribute)]
    public object EventAttractiveness { get; set; }

    [BinaryContent(Name = "lastReducedAttractivenessTimestamp", NodeType = BinaryContentTypes.Attribute)]
    public object LastReducedAttractivenessTimestamp { get; set; }

    [BinaryContent(Name = "feedbackTextAmount", NodeType = BinaryContentTypes.Attribute)]
    public object FeedbackTextAmount { get; set; }

    [BinaryContent(Name = "FeedbackTextIcon", NodeType = BinaryContentTypes.Attribute)]
    public object FeedbackTextIcon { get; set; }

    [BinaryContent(Name = "FeedbackTextGUID", NodeType = BinaryContentTypes.Attribute)]
    public object FeedbackTextGUID { get; set; }

    [BinaryContent(Name = "FeedbackTextPosition", NodeType = BinaryContentTypes.Attribute)]
    public object FeedbackTextPosition { get; set; }

    [BinaryContent(Name = "ProductionState", NodeType = BinaryContentTypes.Node)]
    public MonumentProductionState ProductionState { get; set; }

    [BinaryContent(Name = "EventRewards2", NodeType = BinaryContentTypes.Node)]
    public EventRewards2 EventRewards2 { get; set; }

    [BinaryContent(Name = "EventPreparation", NodeType = BinaryContentTypes.Node)]
    public EventPreparation EventPreparation { get; set; }

  }
}