using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SessionRandomManager {

    [BinaryContent(Name = "NetworkSafeRandom", NodeType = BinaryContentTypes.Node)]
    public SessionRandomManagerNetworkSafeRandom NetworkSafeRandom { get; set; }

  }
}