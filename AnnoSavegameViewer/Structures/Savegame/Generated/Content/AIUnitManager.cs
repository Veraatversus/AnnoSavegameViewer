using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AIUnitManager {

    [BinaryContent(Name = "NextSquadID", NodeType = BinaryContentTypes.Attribute)]
    public object NextSquadID { get; set; }

    [BinaryContent(Name = "Squads", NodeType = BinaryContentTypes.Node)]
    public Squads Squads { get; set; }

    [BinaryContent(Name = "unitsToSquadIDs", NodeType = BinaryContentTypes.Node)]
    public UnitsToSquadIDs UnitsToSquadIDs { get; set; }

  }
}