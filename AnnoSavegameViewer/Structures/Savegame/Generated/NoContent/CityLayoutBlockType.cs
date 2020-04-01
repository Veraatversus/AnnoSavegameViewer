using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CityLayoutBlockType {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public CityLayoutBlockTypeValue Value { get; set; }

  }
}