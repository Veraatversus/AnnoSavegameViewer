namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

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