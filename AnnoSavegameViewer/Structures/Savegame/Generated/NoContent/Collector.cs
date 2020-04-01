using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Collector {

    [BinaryContent(Name = "Collected", NodeType = BinaryContentTypes.Node)]
    public Collected Collected { get; set; }

  }
}