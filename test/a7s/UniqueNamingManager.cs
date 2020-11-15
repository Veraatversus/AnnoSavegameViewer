using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class UniqueNamingManager {

[BinaryContent(Name = "ShipNameList", NodeType = BinaryContentTypes.Node)]
public ShipNameList ShipNameList { get; set; }

[BinaryContent(Name = "ShipNameUsed", NodeType = BinaryContentTypes.Node)]
public ShipNameUsed ShipNameUsed { get; set; }

[BinaryContent(Name = "NextShipNameIndex", NodeType = BinaryContentTypes.Node)]
public NextShipNameIndex NextShipNameIndex { get; set; }

[BinaryContent(Name = "ParticipantSpecificNames", NodeType = BinaryContentTypes.Node)]
public ParticipantSpecificNames ParticipantSpecificNames { get; set; }

[BinaryContent(Name = "ParticipantSpecificNamesUsed", NodeType = BinaryContentTypes.Node)]
public ParticipantSpecificNamesUsed ParticipantSpecificNamesUsed { get; set; }

}
}
