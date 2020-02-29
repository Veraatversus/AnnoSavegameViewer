using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SessionIntervals {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<SessionIntervalsList> SessionIntervalsList { get; set; }

  }
}