using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class PerIncidentDataValue {

[BinaryContent(Name = "infectionChance", NodeType = BinaryContentTypes.Attribute)]
public HexString InfectionChance { get; set; }

[BinaryContent(Name = "infectionChanceDensity", NodeType = BinaryContentTypes.Attribute)]
public HexString InfectionChanceDensity { get; set; }

[BinaryContent(Name = "infectionProximity", NodeType = BinaryContentTypes.Node)]
public InfectionProximity InfectionProximity { get; set; }

[BinaryContent(Name = "protected", NodeType = BinaryContentTypes.Attribute)]
public HexString Protected { get; set; }

[BinaryContent(Name = "factors", NodeType = BinaryContentTypes.Node)]
public Factors Factors { get; set; }

}
}
