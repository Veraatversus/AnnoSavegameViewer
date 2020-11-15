using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class MetaIncidentManager {

[BinaryContent(Name = "BonusIncidentChance", NodeType = BinaryContentTypes.Node)]
public BonusIncidentChance BonusIncidentChance { get; set; }

[BinaryContent(Name = "IncidentInterval", NodeType = BinaryContentTypes.Node)]
public IncidentInterval IncidentInterval { get; set; }

}
}
