using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class VariableValue {

    [BinaryContent(Name = "FloatValue", NodeType = BinaryContentTypes.Node)]
    public FloatValue FloatValue { get; set; }

    [BinaryContent(Name = "Variable", NodeType = BinaryContentTypes.Node)]
    public VariableValueVariable Variable { get; set; }

  }
}