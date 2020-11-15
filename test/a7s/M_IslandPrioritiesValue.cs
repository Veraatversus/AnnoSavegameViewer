using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class M_IslandPrioritiesValue {

[BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
public HexString AreaID { get; set; }

[BinaryContent(Name = "MoneyCost", NodeType = BinaryContentTypes.Attribute)]
public HexString MoneyCost { get; set; }

[BinaryContent(Name = "PrioType", NodeType = BinaryContentTypes.Node)]
public PrioType PrioType { get; set; }

[BinaryContent(Name = "ShareIndex", NodeType = BinaryContentTypes.Attribute)]
public HexString ShareIndex { get; set; }

[BinaryContent(Name = "Prio", NodeType = BinaryContentTypes.Attribute)]
public HexString Prio { get; set; }

[BinaryContent(Name = "MissingMoney", NodeType = BinaryContentTypes.Attribute)]
public HexString MissingMoney { get; set; }

[BinaryContent(Name = "ShareCount", NodeType = BinaryContentTypes.Attribute)]
public HexString ShareCount { get; set; }

}
}
