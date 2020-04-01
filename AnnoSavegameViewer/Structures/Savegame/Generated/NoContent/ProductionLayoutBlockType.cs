using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ProductionLayoutBlockType {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ProductionLayoutBlockTypeValue Value { get; set; }

  }
}