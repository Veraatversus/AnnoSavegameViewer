using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SessionCounterList {

    [BinaryContent(Name = "Counters", NodeType = BinaryContentTypes.Node)]
    public SessionCounterListCounters Counters { get; set; }

  }
}