using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class VerticalEdgesValuesNoneValue {

[BinaryContent(Name = "Positions", NodeType = BinaryContentTypes.Node)]
public Positions Positions { get; set; }

[BinaryContent(Name = "OccupyTimes", NodeType = BinaryContentTypes.Node)]
public OccupyTimes OccupyTimes { get; set; }

[BinaryContent(Name = "SuppressRenderUpdates", NodeType = BinaryContentTypes.Attribute)]
public HexString SuppressRenderUpdates { get; set; }

}
}
