using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class AIUnitManager {

[BinaryContent(Name = "Squads", NodeType = BinaryContentTypes.Node)]
public Squads Squads { get; set; }

[BinaryContent(Name = "unitsToSquadIDs", NodeType = BinaryContentTypes.Node)]
public UnitsToSquadIDs UnitsToSquadIDs { get; set; }

[BinaryContent(Name = "NextSquadID", NodeType = BinaryContentTypes.Attribute)]
public HexString NextSquadID { get; set; }

}
}
