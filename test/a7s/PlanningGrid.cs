using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class PlanningGrid {

[BinaryContent(Name = "GridOrigin", NodeType = BinaryContentTypes.Attribute)]
public HexString GridOrigin { get; set; }

[BinaryContent(Name = "GridMax", NodeType = BinaryContentTypes.Attribute)]
public HexString GridMax { get; set; }

[BinaryContent(Name = "GridDimensions", NodeType = BinaryContentTypes.Attribute)]
public HexString GridDimensions { get; set; }

[BinaryContent(Name = "CellSize", NodeType = BinaryContentTypes.Attribute)]
public HexString CellSize { get; set; }

[BinaryContent(Name = "Grid", NodeType = BinaryContentTypes.Node)]
public PlanningGridGrid Grid { get; set; }

}
}
