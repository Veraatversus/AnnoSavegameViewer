using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Counters {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<CountersList> CountersList { get; set; }

  }
}