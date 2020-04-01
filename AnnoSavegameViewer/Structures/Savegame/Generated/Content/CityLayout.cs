using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CityLayout {

    [BinaryContent(Name = "BlockCount", NodeType = BinaryContentTypes.Attribute)]
    public object BlockCount { get; set; }

    [BinaryContent(Name = "Block", NodeType = BinaryContentTypes.Node)]
    public List<CityLayoutBlock> Block { get; set; }

  }
}