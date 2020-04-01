using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ThreadStateOfEachPeerList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ThreadStateOfEachPeerListValue Value { get; set; }

  }
}