using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaCounterList {

    [BinaryContent(Name = "Counters", NodeType = BinaryContentTypes.Node)]
    public Counters Counters { get; set; }

  }
}