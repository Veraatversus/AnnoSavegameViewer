namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class AdditionalSessionEffects {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<AdditionalSessionEffectsList> AdditionalSessionEffectsList { get; set; }

  }
}