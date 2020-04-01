using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PeerSpecificData {

    [BinaryContent(Name = "SessionData", NodeType = BinaryContentTypes.Node)]
    public PeerSpecificDataSessionData SessionData { get; set; }

  }
}