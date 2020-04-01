using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ConstructionMaterialHandler {

    [BinaryContent(Name = "LastTick", NodeType = BinaryContentTypes.Attribute)]
    public object LastTick { get; set; }

    [BinaryContent(Name = "TransportTasks", NodeType = BinaryContentTypes.Node)]
    public ConstructionMaterialHandlerTransportTasks TransportTasks { get; set; }

    [BinaryContent(Name = "UnlockedMaterials", NodeType = BinaryContentTypes.Node)]
    public UnlockedMaterials UnlockedMaterials { get; set; }

    [BinaryContent(Name = "StockLimits", NodeType = BinaryContentTypes.Node)]
    public StockLimits StockLimits { get; set; }

  }
}