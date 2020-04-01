using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class UniqueNamingManager {

    [BinaryContent(Name = "ShipNameList", NodeType = BinaryContentTypes.Node)]
    public List<ShipNameList> ShipNameList { get; set; }

    [BinaryContent(Name = "ShipNameUsed", NodeType = BinaryContentTypes.Node)]
    public List<ShipNameUsed> ShipNameUsed { get; set; }

    [BinaryContent(Name = "NextShipNameIndex", NodeType = BinaryContentTypes.Node)]
    public List<NextShipNameIndex> NextShipNameIndex { get; set; }

    [BinaryContent(Name = "ParticipantSpecificNames", NodeType = BinaryContentTypes.Node)]
    public ParticipantSpecificNames ParticipantSpecificNames { get; set; }

    [BinaryContent(Name = "ParticipantSpecificNamesUsed", NodeType = BinaryContentTypes.Node)]
    public ParticipantSpecificNamesUsed ParticipantSpecificNamesUsed { get; set; }

  }
}