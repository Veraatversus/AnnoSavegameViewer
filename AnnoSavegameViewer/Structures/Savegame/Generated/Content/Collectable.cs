using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Collectable {

    [BinaryContent(Name = "Collector", NodeType = BinaryContentTypes.Attribute)]
    public object Collector { get; set; }

  }
}