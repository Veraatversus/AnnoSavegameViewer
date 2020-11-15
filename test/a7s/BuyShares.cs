using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class BuyShares {

[BinaryContent(Name = "m_NextCalculationTime", NodeType = BinaryContentTypes.Attribute)]
public HexString M_NextCalculationTime { get; set; }

[BinaryContent(Name = "m_IslandPriorities", NodeType = BinaryContentTypes.Node)]
public M_IslandPriorities M_IslandPriorities { get; set; }

[BinaryContent(Name = "m_IslandsToOvertake", NodeType = BinaryContentTypes.Attribute)]
public HexString M_IslandsToOvertake { get; set; }

}
}
