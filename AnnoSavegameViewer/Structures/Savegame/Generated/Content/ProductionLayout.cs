using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ProductionLayout {

    [BinaryContent(Name = "BlockCount", NodeType = BinaryContentTypes.Attribute)]
    public object BlockCount { get; set; }

    [BinaryContent(Name = "productionLures", NodeType = BinaryContentTypes.Attribute)]
    public object ProductionLures { get; set; }

    [BinaryContent(Name = "Block", NodeType = BinaryContentTypes.Node)]
    public List<ProductionLayoutBlock> Block { get; set; }

  }
}