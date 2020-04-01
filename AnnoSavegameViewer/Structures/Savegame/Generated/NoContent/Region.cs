using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Region {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public RegionValue Value { get; set; }

  }
}