using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ConditionHistoryListValue {

[BinaryContent(Name = "ConditionCombinedText", NodeType = BinaryContentTypes.Node)]
public ConditionCombinedText ConditionCombinedText { get; set; }

[BinaryContent(Name = "ConditionResult", NodeType = BinaryContentTypes.Node)]
public NoneConditionResult ConditionResult { get; set; }

[BinaryContent(Name = "Separator", NodeType = BinaryContentTypes.Node)]
public Separator Separator { get; set; }

}
}
