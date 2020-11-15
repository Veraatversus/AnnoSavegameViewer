using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ConstructionMaterialHandler {

[BinaryContent(Name = "TransportTasks", NodeType = BinaryContentTypes.Node)]
public TransportTasks TransportTasks { get; set; }

[BinaryContent(Name = "UnlockedMaterials", NodeType = BinaryContentTypes.Node)]
public UnlockedMaterials UnlockedMaterials { get; set; }

[BinaryContent(Name = "StockLimits", NodeType = BinaryContentTypes.Node)]
public StockLimits StockLimits { get; set; }

[BinaryContent(Name = "LastTick", NodeType = BinaryContentTypes.Attribute)]
public HexString LastTick { get; set; }

}
}
