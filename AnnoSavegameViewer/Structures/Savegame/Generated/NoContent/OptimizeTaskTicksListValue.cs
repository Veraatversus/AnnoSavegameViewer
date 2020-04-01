using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class OptimizeTaskTicksListValue {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public OptimizeTaskTicksListValueValue Value { get; set; }

  }
}