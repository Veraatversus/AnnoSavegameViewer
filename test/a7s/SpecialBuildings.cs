using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class SpecialBuildings {

[BinaryContent(Name = "CultureItemCheatTime", NodeType = BinaryContentTypes.Attribute)]
public HexString CultureItemCheatTime { get; set; }

[BinaryContent(Name = "NextSpecialBuildingTick", NodeType = BinaryContentTypes.Attribute)]
public HexString NextSpecialBuildingTick { get; set; }

[BinaryContent(Name = "MonumentHandler", NodeType = BinaryContentTypes.Node)]
public MonumentHandler MonumentHandler { get; set; }

}
}
