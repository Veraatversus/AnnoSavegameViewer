using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PeerSpecificDataSessionDataList {

    [BinaryContent(Name = "HasNeverBeenEntered", NodeType = BinaryContentTypes.Attribute)]
    public object HasNeverBeenEntered { get; set; }

  }
}