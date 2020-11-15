using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class Settlement {

[BinaryContent(Name = "SettleHandler", NodeType = BinaryContentTypes.Node)]
public SettleHandler SettleHandler { get; set; }

[BinaryContent(Name = "LastRateTick", NodeType = BinaryContentTypes.Attribute)]
public HexString LastRateTick { get; set; }

[BinaryContent(Name = "IslandCount", NodeType = BinaryContentTypes.Attribute)]
public HexString IslandCount { get; set; }

[BinaryContent(Name = "Island", NodeType = BinaryContentTypes.Node)]
public Island Island { get; set; }

}
}
