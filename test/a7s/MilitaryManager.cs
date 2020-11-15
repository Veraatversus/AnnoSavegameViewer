using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class MilitaryManager {

[BinaryContent(Name = "nextFightID", NodeType = BinaryContentTypes.Attribute)]
public HexString NextFightID { get; set; }

[BinaryContent(Name = "ObjectToFightId", NodeType = BinaryContentTypes.Node)]
public ObjectToFightId ObjectToFightId { get; set; }

[BinaryContent(Name = "FightIdToFight", NodeType = BinaryContentTypes.Node)]
public FightIdToFight FightIdToFight { get; set; }

}
}
