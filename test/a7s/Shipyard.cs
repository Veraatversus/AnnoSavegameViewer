using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class Shipyard {

[BinaryContent(Name = "ConstructionQueue", NodeType = BinaryContentTypes.Node)]
public ConstructionQueue ConstructionQueue { get; set; }

[BinaryContent(Name = "RallyPoint", NodeType = BinaryContentTypes.Attribute)]
public HexString RallyPoint { get; set; }

}
}
