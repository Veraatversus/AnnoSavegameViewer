using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class IncidentTypeDataValue {

[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
public IncidentTypeDataValuesNoneValue Value { get; set; }

[BinaryContent(Name = "Incidents", NodeType = BinaryContentTypes.Node)]
public NoneIncidents Incidents { get; set; }

[BinaryContent(Name = "BuildingInfectionChances", NodeType = BinaryContentTypes.Node)]
public BuildingInfectionChances BuildingInfectionChances { get; set; }

[BinaryContent(Name = "Unlocked", NodeType = BinaryContentTypes.Attribute)]
public HexString Unlocked { get; set; }

[BinaryContent(Name = "AreaInfectionChance", NodeType = BinaryContentTypes.Attribute)]
public HexString AreaInfectionChance { get; set; }

}
}
