using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class LastWorkingConditionsEvaluationValue {

[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
public LastWorkingConditionsEvaluationValuesNoneValue Value { get; set; }

[BinaryContent(Name = "LastValue", NodeType = BinaryContentTypes.Attribute)]
public HexString LastValue { get; set; }

[BinaryContent(Name = "PositiveThresholdLevel", NodeType = BinaryContentTypes.Attribute)]
public HexString PositiveThresholdLevel { get; set; }

[BinaryContent(Name = "NegativeThresholdLevel", NodeType = BinaryContentTypes.Attribute)]
public HexString NegativeThresholdLevel { get; set; }

}
}
