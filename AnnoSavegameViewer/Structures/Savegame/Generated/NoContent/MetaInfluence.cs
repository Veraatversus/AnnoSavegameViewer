using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MetaInfluence {

    [BinaryContent(Name = "UsedAmount", NodeType = BinaryContentTypes.Node)]
    public UsedAmount UsedAmount { get; set; }

    [BinaryContent(Name = "SpentInfluence", NodeType = BinaryContentTypes.Node)]
    public SpentInfluence SpentInfluence { get; set; }

    [BinaryContent(Name = "OldSpentInfluence", NodeType = BinaryContentTypes.Node)]
    public OldSpentInfluence OldSpentInfluence { get; set; }

    [BinaryContent(Name = "InfluenceBuffs", NodeType = BinaryContentTypes.Node)]
    public InfluenceBuffs InfluenceBuffs { get; set; }

  }
}