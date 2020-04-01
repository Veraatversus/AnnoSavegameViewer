using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class BuyShares {

    [BinaryContent(Name = "m_NextCalculationTime", NodeType = BinaryContentTypes.Attribute)]
    public object M_NextCalculationTime { get; set; }

    [BinaryContent(Name = "m_IslandsToOvertake", NodeType = BinaryContentTypes.Attribute)]
    public object M_IslandsToOvertake { get; set; }

    [BinaryContent(Name = "m_IslandPriorities", NodeType = BinaryContentTypes.Node)]
    public M_IslandPriorities M_IslandPriorities { get; set; }

  }
}