using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class VariableValue {

[BinaryContent(Name = "FloatValue", NodeType = BinaryContentTypes.Node)]
public FloatValue FloatValue { get; set; }

[BinaryContent(Name = "Variable", NodeType = BinaryContentTypes.Node)]
public VariableValueVariable Variable { get; set; }

}
}
