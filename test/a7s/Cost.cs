using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class Cost {

[BinaryContent(Name = "BuildCosts", NodeType = BinaryContentTypes.Node)]
public BuildCosts BuildCosts { get; set; }

[BinaryContent(Name = "InfluenceCosts", NodeType = BinaryContentTypes.Node)]
public InfluenceCosts InfluenceCosts { get; set; }

[BinaryContent(Name = "RoundUp", NodeType = BinaryContentTypes.Attribute)]
public HexString RoundUp { get; set; }

}
}
