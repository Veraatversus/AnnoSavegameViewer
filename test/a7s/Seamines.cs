using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class Seamines {

[BinaryContent(Name = "MineProhibitZones", NodeType = BinaryContentTypes.Node)]
public MineProhibitZones MineProhibitZones { get; set; }

[BinaryContent(Name = "TargetPos", NodeType = BinaryContentTypes.Node)]
public TargetPos TargetPos { get; set; }

[BinaryContent(Name = "CurrentMines", NodeType = BinaryContentTypes.Node)]
public CurrentMines CurrentMines { get; set; }

[BinaryContent(Name = "VisitedHarbors", NodeType = BinaryContentTypes.Node)]
public VisitedHarbors VisitedHarbors { get; set; }

[BinaryContent(Name = "NextMineSpawn", NodeType = BinaryContentTypes.Attribute)]
public HexString NextMineSpawn { get; set; }

[BinaryContent(Name = "MineAreas", NodeType = BinaryContentTypes.Node)]
public MineAreas MineAreas { get; set; }

}
}
