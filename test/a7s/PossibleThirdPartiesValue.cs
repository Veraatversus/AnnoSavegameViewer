using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class PossibleThirdPartiesValue {

[BinaryContent(Name = "ProfileGUID", NodeType = BinaryContentTypes.Attribute)]
public HexString ProfileGUID { get; set; }

[BinaryContent(Name = "ActiveRegions", NodeType = BinaryContentTypes.Node)]
public ActiveRegions ActiveRegions { get; set; }

}
}
