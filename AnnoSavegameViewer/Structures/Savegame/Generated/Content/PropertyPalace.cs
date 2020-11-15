namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class PropertyPalace {

    [BinaryContent(Name = "EffectRange", NodeType = BinaryContentTypes.Attribute)]
    public object EffectRange { get; set; }

    [BinaryContent(Name = "ParagonLevel", NodeType = BinaryContentTypes.Attribute)]
    public object ParagonLevel { get; set; }

    [BinaryContent(Name = "NewParagonLevel", NodeType = BinaryContentTypes.Attribute)]
    public object NewParagonLevel { get; set; }

    [BinaryContent(Name = "LastAreaAttractiveness", NodeType = BinaryContentTypes.Attribute)]
    public object LastAreaAttractiveness { get; set; }

    [BinaryContent(Name = "ActiveDecrees", NodeType = BinaryContentTypes.Node)]
    public ActiveDecrees ActiveDecrees { get; set; }

    [BinaryContent(Name = "MinistryStates", NodeType = BinaryContentTypes.Node)]
    public MinistryStates MinistryStates { get; set; }

    [BinaryContent(Name = "DecreeStates", NodeType = BinaryContentTypes.Node)]
    public DecreeStates DecreeStates { get; set; }

    [BinaryContent(Name = "ActiveEffects", NodeType = BinaryContentTypes.Node)]
    public PropertyPalaceActiveEffects ActiveEffects { get; set; }

  }
}