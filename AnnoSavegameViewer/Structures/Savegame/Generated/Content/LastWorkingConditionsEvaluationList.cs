using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class LastWorkingConditionsEvaluationList {

    [BinaryContent(Name = "LastValue", NodeType = BinaryContentTypes.Attribute)]
    public object LastValue { get; set; }

    [BinaryContent(Name = "PositiveThresholdLevel", NodeType = BinaryContentTypes.Attribute)]
    public object PositiveThresholdLevel { get; set; }

    [BinaryContent(Name = "NegativeThresholdLevel", NodeType = BinaryContentTypes.Attribute)]
    public object NegativeThresholdLevel { get; set; }

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public LastWorkingConditionsEvaluationListValue Value { get; set; }

  }
}