using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class SnapshotsValue {

[BinaryContent(Name = "CreationTime", NodeType = BinaryContentTypes.Attribute)]
public HexString CreationTime { get; set; }

[BinaryContent(Name = "AmountPerPopulation", NodeType = BinaryContentTypes.Node)]
public AmountPerPopulation AmountPerPopulation { get; set; }

[BinaryContent(Name = "AmountPerProduct", NodeType = BinaryContentTypes.Node)]
public AmountPerProduct AmountPerProduct { get; set; }

[BinaryContent(Name = "GenerationPerProduct", NodeType = BinaryContentTypes.Node)]
public GenerationPerProduct GenerationPerProduct { get; set; }

[BinaryContent(Name = "ConsumptionPerProduct", NodeType = BinaryContentTypes.Node)]
public ConsumptionPerProduct ConsumptionPerProduct { get; set; }

}
}
