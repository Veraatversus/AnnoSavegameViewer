using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class AreaIncidentManager {

[BinaryContent(Name = "incidentTypeData", NodeType = BinaryContentTypes.Node)]
public IncidentTypeData IncidentTypeData { get; set; }

[BinaryContent(Name = "militaryTakeoverProgress", NodeType = BinaryContentTypes.Attribute)]
public HexString MilitaryTakeoverProgress { get; set; }

}
}
