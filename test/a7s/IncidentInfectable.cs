using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class IncidentInfectable {

[BinaryContent(Name = "perIncidentData", NodeType = BinaryContentTypes.Node)]
public PerIncidentData PerIncidentData { get; set; }

[BinaryContent(Name = "activeType", NodeType = BinaryContentTypes.Node)]
public IncidentInfectableActiveType ActiveType { get; set; }

[BinaryContent(Name = "DensityBuffer", NodeType = BinaryContentTypes.Attribute)]
public HexString DensityBuffer { get; set; }

[BinaryContent(Name = "intensityInterval", NodeType = BinaryContentTypes.Attribute)]
public HexString IntensityInterval { get; set; }

}
}
