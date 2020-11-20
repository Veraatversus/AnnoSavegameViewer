namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class LastWorkingConditionsEvaluationList {

    #region Public Properties

    [BinaryContent(Name = "LastValue", NodeType = BinaryContentTypes.Attribute)]
    public object LastValue { get; set; }

    [BinaryContent(Name = "PositiveThresholdLevel", NodeType = BinaryContentTypes.Attribute)]
    public object PositiveThresholdLevel { get; set; }

    [BinaryContent(Name = "NegativeThresholdLevel", NodeType = BinaryContentTypes.Attribute)]
    public object NegativeThresholdLevel { get; set; }

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public LastWorkingConditionsEvaluationListValue Value { get; set; }

    #endregion Public Properties
  }
}