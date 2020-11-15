using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class Available {

[BinaryContent(Name = "ParticipantType", NodeType = BinaryContentTypes.Node)]
public ParticipantType ParticipantType { get; set; }

[BinaryContent(Name = "Team", NodeType = BinaryContentTypes.Node)]
public Team Team { get; set; }

[BinaryContent(Name = "Coop", NodeType = BinaryContentTypes.Attribute)]
public HexString Coop { get; set; }

[BinaryContent(Name = "CompanyColor", NodeType = BinaryContentTypes.Node)]
public CompanyColor CompanyColor { get; set; }

[BinaryContent(Name = "PlayerPossessions", NodeType = BinaryContentTypes.Attribute)]
public HexString PlayerPossessions { get; set; }

}
}
