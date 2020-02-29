using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ThreadStateOfEachPeer {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ThreadStateOfEachPeerList> ThreadStateOfEachPeerList { get; set; }

  }
}