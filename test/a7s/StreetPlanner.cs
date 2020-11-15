using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class StreetPlanner {

[BinaryContent(Name = "StreetUpgradeAreas", NodeType = BinaryContentTypes.Node)]
public StreetUpgradeAreas StreetUpgradeAreas { get; set; }

[BinaryContent(Name = "StreetUpgradeTimestamp", NodeType = BinaryContentTypes.Attribute)]
public HexString StreetUpgradeTimestamp { get; set; }

[BinaryContent(Name = "Bridges", NodeType = BinaryContentTypes.Node)]
public Bridges Bridges { get; set; }

}
}
