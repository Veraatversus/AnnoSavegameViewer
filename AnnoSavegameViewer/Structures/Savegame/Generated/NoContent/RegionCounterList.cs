using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class RegionCounterList {

    [BinaryContent(Name = "Counters", NodeType = BinaryContentTypes.Node)]
    public RegionCounterListCounters Counters { get; set; }

  }
}