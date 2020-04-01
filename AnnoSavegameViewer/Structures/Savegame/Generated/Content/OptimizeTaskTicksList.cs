using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class OptimizeTaskTicksList {

    [BinaryContent(Name = "LastTrigger", NodeType = BinaryContentTypes.Attribute)]
    public object LastTrigger { get; set; }

    [BinaryContent(Name = "BuildCount", NodeType = BinaryContentTypes.Attribute)]
    public object BuildCount { get; set; }

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public OptimizeTaskTicksListValue Value { get; set; }

  }
}