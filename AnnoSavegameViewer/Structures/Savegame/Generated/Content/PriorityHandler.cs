using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PriorityHandler {

    [BinaryContent(Name = "ProductionCount", NodeType = BinaryContentTypes.Attribute)]
    public object ProductionCount { get; set; }

    [BinaryContent(Name = "Prios", NodeType = BinaryContentTypes.Node)]
    public Prios Prios { get; set; }

  }
}