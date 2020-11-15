using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class AreaFestivalManager {

[BinaryContent(Name = "nextTick", NodeType = BinaryContentTypes.Attribute)]
public HexString NextTick { get; set; }

[BinaryContent(Name = "activeType", NodeType = BinaryContentTypes.Node)]
public ActiveType ActiveType { get; set; }

[BinaryContent(Name = "activeEffects", NodeType = BinaryContentTypes.Node)]
public ActiveEffects ActiveEffects { get; set; }

[BinaryContent(Name = "poolThreshold", NodeType = BinaryContentTypes.Attribute)]
public HexString PoolThreshold { get; set; }

[BinaryContent(Name = "poolVal", NodeType = BinaryContentTypes.Attribute)]
public HexString PoolVal { get; set; }

}
}
