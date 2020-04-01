using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MapSize {

    [BinaryContent(Name = "mapSize", NodeType = BinaryContentTypes.Attribute)]
    public object MapSizeItem { get; set; }

  }
}