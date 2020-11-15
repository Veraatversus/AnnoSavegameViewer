using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class TemplateElementElement {

[BinaryContent(Name = "Position", NodeType = BinaryContentTypes.Attribute)]
public HexString Position { get; set; }

[BinaryContent(Name = "MapFilePath", NodeType = BinaryContentTypes.Attribute)]
public HexString MapFilePath { get; set; }

[BinaryContent(Name = "Rotation90", NodeType = BinaryContentTypes.Attribute)]
public HexString Rotation90 { get; set; }

[BinaryContent(Name = "IslandLabel", NodeType = BinaryContentTypes.Attribute)]
public HexString IslandLabel { get; set; }

[BinaryContent(Name = "FertilityGuids", NodeType = BinaryContentTypes.Attribute)]
public HexString FertilityGuids { get; set; }

[BinaryContent(Name = "RandomizeFertilities", NodeType = BinaryContentTypes.Attribute)]
public HexString RandomizeFertilities { get; set; }

[BinaryContent(Name = "MineSlotMapping", NodeType = BinaryContentTypes.Node)]
public MineSlotMapping MineSlotMapping { get; set; }

[BinaryContent(Name = "RandomIslandConfig", NodeType = BinaryContentTypes.Node)]
public RandomIslandConfig RandomIslandConfig { get; set; }

}
}
