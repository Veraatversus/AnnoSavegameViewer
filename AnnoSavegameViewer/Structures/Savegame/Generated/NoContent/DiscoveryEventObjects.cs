using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DiscoveryEventObjects {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<DiscoveryEventObjectsList> DiscoveryEventObjectsList { get; set; }

  }
}