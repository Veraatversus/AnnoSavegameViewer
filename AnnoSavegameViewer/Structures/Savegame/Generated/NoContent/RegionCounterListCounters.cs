using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class RegionCounterListCounters {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<RegionCounterListCountersList> RegionCounterListCountersList { get; set; }

  }
}