using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PeerToSessionMap {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<PeerToSessionMapList> PeerToSessionMapList { get; set; }

  }
}