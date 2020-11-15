using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ResolverUnitsValue {

[BinaryContent(Name = "institutionID", NodeType = BinaryContentTypes.Node)]
public InstitutionID InstitutionID { get; set; }

[BinaryContent(Name = "id", NodeType = BinaryContentTypes.Node)]
public Id Id { get; set; }

[BinaryContent(Name = "dummyObject", NodeType = BinaryContentTypes.Attribute)]
public HexString DummyObject { get; set; }

[BinaryContent(Name = "unlockTime", NodeType = BinaryContentTypes.Attribute)]
public HexString UnlockTime { get; set; }

[BinaryContent(Name = "incidentType", NodeType = BinaryContentTypes.Node)]
public IncidentType IncidentType { get; set; }

}
}
