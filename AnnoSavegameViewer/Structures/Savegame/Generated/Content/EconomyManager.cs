using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class EconomyManager {

    [BinaryContent(Name = "MetaStorageCount", NodeType = BinaryContentTypes.Attribute)]
    public object MetaStorageCount { get; set; }

    [BinaryContent(Name = "Pair", NodeType = BinaryContentTypes.Node)]
    public List<Pair> Pair { get; set; }

  }
}