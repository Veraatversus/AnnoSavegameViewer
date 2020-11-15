using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class IncidentResolver {

[BinaryContent(Name = "resolverUnits", NodeType = BinaryContentTypes.Node)]
public ResolverUnits ResolverUnits { get; set; }

[BinaryContent(Name = "specialUnits", NodeType = BinaryContentTypes.Node)]
public SpecialUnits SpecialUnits { get; set; }

[BinaryContent(Name = "specialActionCooldown", NodeType = BinaryContentTypes.Attribute)]
public HexString SpecialActionCooldown { get; set; }

}
}
