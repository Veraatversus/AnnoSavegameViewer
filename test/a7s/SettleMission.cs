using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class SettleMission {

[BinaryContent(Name = "AssignedShip", NodeType = BinaryContentTypes.Node)]
public AssignedShip AssignedShip { get; set; }

[BinaryContent(Name = "SettleLocation", NodeType = BinaryContentTypes.Node)]
public SettleLocation SettleLocation { get; set; }

[BinaryContent(Name = "SettleParams", NodeType = BinaryContentTypes.Node)]
public SettleParams SettleParams { get; set; }

}
}
