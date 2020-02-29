using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SessionCounterListCounters {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<SessionCounterListCountersList> SessionCounterListCountersList { get; set; }

  }
}