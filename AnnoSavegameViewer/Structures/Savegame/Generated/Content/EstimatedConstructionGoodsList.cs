using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class EstimatedConstructionGoodsList {

    [BinaryContent(Name = "Product", NodeType = BinaryContentTypes.Attribute)]
    public object Product { get; set; }

    [BinaryContent(Name = "Count", NodeType = BinaryContentTypes.Attribute)]
    public object Count { get; set; }

  }
}