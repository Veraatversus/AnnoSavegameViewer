using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ShipIncident {

[BinaryContent(Name = "activeType", NodeType = BinaryContentTypes.Node)]
public ShipIncidentActiveType ActiveType { get; set; }

}
}
