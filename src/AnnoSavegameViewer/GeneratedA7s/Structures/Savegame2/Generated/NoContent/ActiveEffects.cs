namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class ActiveEffects {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ActiveEffectsList> ActiveEffectsList { get; set; }

  }
}