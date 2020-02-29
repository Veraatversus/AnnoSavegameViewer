using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class GlobalCounterCounters {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<GlobalCounterCountersList> GlobalCounterCountersList { get; set; }

  }
}