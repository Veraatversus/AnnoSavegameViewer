using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class VariableValueVariable {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public VariableValueVariableValue Value { get; set; }

  }
}