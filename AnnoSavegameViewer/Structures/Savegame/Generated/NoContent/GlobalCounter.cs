using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class GlobalCounter {

    [BinaryContent(Name = "Counters", NodeType = BinaryContentTypes.Node)]
    public GlobalCounterCounters Counters { get; set; }

  }
}