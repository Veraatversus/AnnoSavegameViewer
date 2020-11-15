using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class IncidentManager {

[BinaryContent(Name = "NextIncidentID", NodeType = BinaryContentTypes.Attribute)]
public HexString NextIncidentID { get; set; }

[BinaryContent(Name = "Incidents", NodeType = BinaryContentTypes.Node)]
public Incidents Incidents { get; set; }

[BinaryContent(Name = "SessionIntervals", NodeType = BinaryContentTypes.Node)]
public SessionIntervals SessionIntervals { get; set; }

}
}
