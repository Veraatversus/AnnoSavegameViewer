using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CachePerSessionList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public CachePerSessionListValue Value { get; set; }

  }
}