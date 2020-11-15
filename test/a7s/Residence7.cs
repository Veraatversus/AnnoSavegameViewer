using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class Residence7 {

[BinaryContent(Name = "ResidentCount", NodeType = BinaryContentTypes.Attribute)]
public HexString ResidentCount { get; set; }

[BinaryContent(Name = "ResidenceState", NodeType = BinaryContentTypes.Node)]
public ResidenceState ResidenceState { get; set; }

[BinaryContent(Name = "TimeBeforeRuinLeft", NodeType = BinaryContentTypes.Attribute)]
public HexString TimeBeforeRuinLeft { get; set; }

[BinaryContent(Name = "PopulationMoveTimeout", NodeType = BinaryContentTypes.Attribute)]
public HexString PopulationMoveTimeout { get; set; }

[BinaryContent(Name = "ProductMoneyOutput", NodeType = BinaryContentTypes.Attribute)]
public HexString ProductMoneyOutput { get; set; }

[BinaryContent(Name = "AverageNeedSaturation", NodeType = BinaryContentTypes.Attribute)]
public HexString AverageNeedSaturation { get; set; }

[BinaryContent(Name = "ConsumptionStates", NodeType = BinaryContentTypes.Node)]
public ConsumptionStates ConsumptionStates { get; set; }

}
}
